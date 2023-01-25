namespace DataGrid
{
    public class File
    {

        private string name = "";
        private string base64Data = "";
        private string type = "";
        private long size;

        

        public string Name { get { return name; } set { name = value; } }

        public string Base64Data { get { return base64Data; } set { base64Data = value; } }

        public string Type { get { return type; } set { type = value; } }

        public long Size { get { return size; } set { size = value; } }

        public File() {
        
        } 
        public File(string name, string base64Data, string type, long size) {

            this.name = name;
            this.base64Data = base64Data;
            this.type = type;
            this.size = size;

        }


    }
}
