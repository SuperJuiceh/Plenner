using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace Planner.Data.Tools.GUI
{
    public class PlannerFilePicker
    {

        public List<string> FileTypes = new List<string>();

        public enum SelectFilesModes { Single, Multiple }

        public SelectFilesModes SelectFilesMode = SelectFilesModes.Single;

        public List<StorageFile> SelectedStorageFiles { get; private set; } = new List<StorageFile>();
        
        public PlannerFilePicker(List<string> fileTypes)
        {
            if (fileTypes == null)
                this.FileTypes = new List<string>() { "*" };
            else
                this.FileTypes = fileTypes;
        }

        public async void PickFile()
        {
            FileOpenPicker picker = new FileOpenPicker();
            FileTypes.ForEach(flType => picker.FileTypeFilter.Add(flType));
            picker.SuggestedStartLocation = PickerLocationId.Downloads;
            picker.ViewMode = PickerViewMode.List;

            switch (SelectFilesMode)
            {
                case SelectFilesModes.Single:
                    StorageFile f = await picker.PickSingleFileAsync();
                    Debug.WriteLine(f.Name);
                    SelectedStorageFiles.Add(f);
                    break;
                case SelectFilesModes.Multiple:
                    (await picker.PickMultipleFilesAsync()).ToList().ForEach(file =>
                    {
                        if (!SelectedStorageFiles.Contains(file))
                            SelectedStorageFiles.Add(file);
                    });
                    break;
            }

            Debug.WriteLine(this.ToString());
        }

        public void addTypeToFilter(string flType)
        {
            if (!FileTypes.Contains(flType))
                FileTypes.Add(flType);
        }
        public void removeTypeFromFilter(string flType)
        {
            FileTypes.Remove(flType);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder(200 * SelectedStorageFiles.Count());
            str.AppendLine(String.Format("Found {0} files:", SelectedStorageFiles.Count().ToString()));

            StorageFile file = null;
            for (int counter = 0;  counter < SelectedStorageFiles.Count(); file = SelectedStorageFiles[counter], counter++)
            {
                if (counter == 0) // Set here to prevent null ref exception
                    file = SelectedStorageFiles[0];

                string a = String.Format("{0}. Name: {1} Path: {2}", (counter+1).ToString(), file.Name, file.Path);
            }
            return str.ToString();
        }
    }

    public static class PlannerFilePickerExtra
    {

        public static List<string> PlanningFileTypeList = new List<string>() { ".pln" };
    }
}
