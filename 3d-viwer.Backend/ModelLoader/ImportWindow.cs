using System.Windows.Forms;

namespace _3d_viwer.Backend.ModelLoader
{
    public class ImportWindow
    {
        private const string FFILTER = "OBJ files (*.obj)|*.obj";
        private string _filePath;

        public void openWindow(OpenFileDialog ofd)
        {
            ofd.Filter = FFILTER;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _filePath = ofd.FileName;

                //Обработка
            }
        }

        public string FilePath
        {
            get { return _filePath; }
        }
    }
}
