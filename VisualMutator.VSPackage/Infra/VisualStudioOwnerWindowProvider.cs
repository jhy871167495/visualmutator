namespace PiotrTrzpil.VisualMutator_VSPackage.Model
{
    #region

    using System.Windows;
    using System.Windows.Interop;
    using UsefulTools.Wpf;
    using VisualMutator.Infrastructure;
    using IWin32Window = System.Windows.Forms.IWin32Window;

    #endregion

    public class VisualStudioOwnerWindowProvider : IOwnerWindowProvider
    {
        private readonly VisualStudioConnection _hostEnviroment;

        public VisualStudioOwnerWindowProvider(VisualStudioConnection hostEnviroment)
        {
            _hostEnviroment = hostEnviroment;
        }


        public IWin32Window GetWindow()
        {
            throw new System.NotImplementedException();
        }

        public void SetOwnerFor(Window window)
        {
            NativeWindowInfo vsWindow = _hostEnviroment.WindowInfo;
            WindowInteropHelper helper = new WindowInteropHelper(window);
            helper.Owner = vsWindow.Handle;
        }

        public string GetWindowTitle()
        {
            return "VisualMutator";
        }
    }
}