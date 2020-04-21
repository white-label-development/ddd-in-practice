using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ddd.UI.Common;

namespace Ddd.UI.Utils
{
    public class DialogService
    {
        public bool? ShowDialog(ViewModel viewModel)
        {
            CustomWindow window = new CustomWindow(viewModel);
            return window.ShowDialog();
        }
    }
}
