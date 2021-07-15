using Newtonsoft.Json;

namespace Company.Function
{
    public class Counter
    {
        [JsonProperty(PropertyName = "id")]
        public Counter(string id, int count)
        {
            this.Id = id;
            this.SetCount(count);

        }
        public string Id { get; set; }

        private int count;

        public int GetCount()
        {
            return count;
        }

        public void SetCount(int value)
        {
            count = value;
        }
