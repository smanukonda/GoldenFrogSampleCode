using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;

namespace GoldenFrogLogin.Model
{
    /// <summary>
    /// Model class to handle login
    /// </summary>
    public class LoginModel : INotifyPropertyChanged
    {
        #region Private Variables

        private string _userName { get; set; }
        private SecureString _password { get; set; }

        #endregion

        #region Public Variables

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged();
            }
        }

        public SecureString Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Public Methods
 
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(UserName) && Password != null && Password.Length > 0;
        }
        /// <summary>
        /// Resets the user name and pasword to null
        /// </summary>
        public void Reset()
        {
            UserName = null;
            Password = null;
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
