namespace DataGrid
{
    public class Storage
    {

        List<File> files = new List<File>();

        public void addFile(File file)
        {
            files.Add(file);
        }
    }
}
