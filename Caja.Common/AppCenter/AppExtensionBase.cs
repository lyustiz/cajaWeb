using System.ComponentModel;

namespace App.Common
{
    public abstract class AppExtensionBase
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

    }
}