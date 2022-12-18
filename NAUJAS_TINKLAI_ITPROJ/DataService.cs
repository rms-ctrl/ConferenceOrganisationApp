namespace NAUJAS_TINKLAI_ITPROJ
{
    public class DataService
    {
        private Dictionary<string, object> _data = new Dictionary<string, object>();

        public void SetData(string key, object value)
        {
            _data[key] = value;
        }

        public object GetData(string key)
        {
            return _data[key];
        }

        public bool ContainsKey(string key)
        {
            return _data.ContainsKey(key);
        }

        public void RemoveData(string key)
        {
            _data.Remove(key);
        }
    }
}
