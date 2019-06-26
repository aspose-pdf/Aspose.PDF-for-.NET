namespace Aspose.Pdf.Examples.CSharp.AsposePDFFacades.Printing
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Security.Principal;
	using System.Runtime.InteropServices;
	using System.ComponentModel;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Impersonation of a user. Allows to execute code under another
	/// User context.
	/// Please note that the account that instantiates the Impersonator class
	/// Needs to have the 'Act as part of operating system' privilege set.
	/// </summary>
	/// <remarks>	
	/// This class is based on the information in the Microsoft knowledge base
	/// Article http:// Support.microsoft.com/default.aspx?scid=kb;en-us;Q306158
	/// 
	/// Encapsulate an instance into a using-directive like e.g.:
	/// 
	///		...
	///		using ( new Impersonator( "myUsername", "myDomainname", "myPassword" ) )
	///		{
	///			...
	///			[code that executes under the new context]
	///			...
	///		}
	///		...
	/// 
	/// Please contact the author Uwe Keim (mailto:uwe.keim@zeta-software.de)
	/// For questions regarding this class.
	/// </remarks>
	public class Impersonator :
		IDisposable
	{
		#region Public methods.
		// ------------------------------------------------------------------

		/// <summary>
		/// Constructor. Starts the impersonation with the given credentials.
		/// Please note that the account that instantiates the Impersonator class
		/// Needs to have the 'Act as part of operating system' privilege set.
		/// </summary>
		/// <param name="userName">The name of the user to act as.</param>
		/// <param name="domainName">The domain name of the user to act as.</param>
		/// <param name="password">The password of the user to act as.</param>
		public Impersonator(
			string userName,
			string domainName,
			string password )
		{
			ImpersonateValidUser( userName, domainName, password );
		}

		// ------------------------------------------------------------------
		#endregion

		#region IDisposable member.
		// ------------------------------------------------------------------

		public void Dispose()
		{
			UndoImpersonation();
		}

		// ------------------------------------------------------------------
		#endregion

		#region P/Invoke.
		// ------------------------------------------------------------------

		[DllImport("advapi32.dll", SetLastError=true)]
		private static extern int LogonUser(
			string lpszUserName,
			string lpszDomain,
			string lpszPassword,
			int dwLogonType,
			int dwLogonProvider,
			ref IntPtr phToken);
		
		[DllImport("advapi32.dll", CharSet=CharSet.Auto, SetLastError=true)]
		private static extern int DuplicateToken(
			IntPtr hToken,
			int impersonationLevel,
			ref IntPtr hNewToken);

		[DllImport("advapi32.dll", CharSet=CharSet.Auto, SetLastError=true)]
		private static extern bool RevertToSelf();

		[DllImport("kernel32.dll", CharSet=CharSet.Auto)]
		private static extern  bool CloseHandle(
			IntPtr handle);

		private const int LOGON32_LOGON_INTERACTIVE = 2;
		private const int LOGON32_PROVIDER_DEFAULT = 0;

		// ------------------------------------------------------------------
		#endregion

		#region Private member.
		// ------------------------------------------------------------------

		/// <summary>
		/// Does the actual impersonation.
		/// </summary>
		/// <param name="userName">The name of the user to act as.</param>
		/// <param name="domainName">The domain name of the user to act as.</param>
		/// <param name="password">The password of the user to act as.</param>
		private void ImpersonateValidUser(
			string userName, 
			string domain, 
			string password )
		{
			WindowsIdentity tempWindowsIdentity = null;
			IntPtr token = IntPtr.Zero;
			IntPtr tokenDuplicate = IntPtr.Zero;

			try
			{
				if ( RevertToSelf() )
				{
					if ( LogonUser(
						userName, 
						domain, 
						password, 
						LOGON32_LOGON_INTERACTIVE,
						LOGON32_PROVIDER_DEFAULT, 
						ref token ) != 0 )
					{
						if ( DuplicateToken( token, 2, ref tokenDuplicate ) != 0 )
						{
							tempWindowsIdentity = new WindowsIdentity( tokenDuplicate );
							impersonationContext = tempWindowsIdentity.Impersonate();
						}
						else
						{
							throw new Win32Exception( Marshal.GetLastWin32Error() );
						}
					}
					else
					{
						throw new Win32Exception( Marshal.GetLastWin32Error() );
					}
				}
				else
				{
					throw new Win32Exception( Marshal.GetLastWin32Error() );
				}
			}
			finally
			{
				if ( token!= IntPtr.Zero )
				{
					CloseHandle( token );
				}
				if ( tokenDuplicate!=IntPtr.Zero )
				{
					CloseHandle( tokenDuplicate );
				}
			}
		}

		/// <summary>
		/// Reverts the impersonation.
		/// </summary>
		private void UndoImpersonation()
		{
			if ( impersonationContext!=null )
			{
				impersonationContext.Undo();
			}	
		}

		private WindowsImpersonationContext impersonationContext = null;

		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}