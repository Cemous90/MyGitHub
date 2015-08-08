namespace MyTrunk.Services.Base
{
    public class BaseService<T> where T : class, new()
    {
// ReSharper disable once InconsistentNaming
        private static readonly T _instance = new T();

        public static T Instance
        {
            get { return _instance; }
        }
    }
}