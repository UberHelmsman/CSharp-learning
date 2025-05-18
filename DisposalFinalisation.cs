using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace GettingStarted;

public class ResourceHolder2 : IDisposable
{
    private readonly SafeHandle managedResorce;
    public ResourceHolder2()
    {
        managedResorce = new SafeFileHandle(new IntPtr(), true);
    }
    public void Dispose()
    {
        managedResorce?.Dispose();
        GC.SuppressFinalize(this);
    }
}
