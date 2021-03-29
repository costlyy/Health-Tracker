using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Tracker
{
	public partial class formLanding : Form
	{
		private EventData _data = null;

		public formLanding()
		{
			InitializeComponent();

			// version / build date

			LoadData();
		}

		private void LoadData()
		{
			Debug.WriteLine("Loading data...");

			if (CheckDirectoryIntegrity())
			{
				Debug.WriteLine("... data found, attempting to import");

				if (ParseData())
				{
					Debug.WriteLine("Import successful");
				}
				else
				{
					Debug.WriteLine("Import unsuccessful");
				}

				return;
			}
		
			Debug.WriteLine("... data not found, attempting to create new");

			if (CreateData())
			{
				Debug.WriteLine("Data create successful");
			}
			else
			{
				Debug.WriteLine("Data create unsuccessful");
			}
		}

		private bool CreateData()
		{
			if (!CheckLocalDocuments(out string myDocs))
			{
				return false;
			}

			myDocs += @"\HealthData\csv";

			Directory.CreateDirectory(myDocs);
			Debug.WriteLine($"Created new data directory:\n{myDocs}");
			return true;
		}

		private bool ParseData()
		{
			if (!CheckLocalDocuments(out string _localDocs))
			{
				return false;
			}

			var _parser = new EventDataParser();

			if ( _parser.Execute(ref _data))
				return true;

			return false;
		}

		private bool CheckDirectoryIntegrity()
		{
			return CheckLocalDocuments(out string _) && CheckLocalDocumentsNameCsv(out string _);
		}

		private bool CheckLocalDocuments(out string myDocsPath)
		{
			myDocsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			try
			{
				if (!Directory.Exists(myDocsPath))
				{
					Debug.WriteLine("Error: Could not find folder named 'My Documents'");
					return false;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"Exception looking for my docs:\n\n:{ex}");
				return false;
			}

			return true;
		}

		private bool CheckLocalDocumentsNameCsv(out string myDocs)
		{
			myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

			try
			{
				if (!Directory.Exists(myDocs))
				{
					Debug.WriteLine($"Could not find folder named '{myDocs}'");
					return false;
				}

				myDocs += @"\HealthData\csv";

				if (!Directory.Exists(myDocs))
				{
					Debug.WriteLine($"Could not find folder named '{myDocs}'");
					return false;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"Exception looking for my docs ({myDocs}):\n\n:{ex}");
				return false;
			}

			return true;
		}

		private void btnViewData_Click(object sender, EventArgs e)
		{
			// Save as dialog
			SaveFileDialog dialog = new SaveFileDialog();
			DialogResult result = dialog.ShowDialog();

			switch (result)
			{
				case DialogResult.None:
				case DialogResult.Abort:
				case DialogResult.Cancel:
				case DialogResult.Ignore:
				case DialogResult.No:
				case DialogResult.Retry:
					return;

				case DialogResult.OK:
				case DialogResult.Yes:
					break;
				default:
					throw new ArgumentOutOfRangeException();

			}


			string ex = "";
// Export to csv / excel
		}

		private void btnNewEntry_Click(object sender, EventArgs e)
		{
			InputForm newForm = new InputForm();
			var result = newForm.ShowDialog(this);
		}
	}
}
