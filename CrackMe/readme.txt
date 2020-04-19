
Get IL code cmd:
	cd "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools"
	ildasm /out="C:\Users\InsYst3m~\Source\Repos\Debugging\CrackMe\Dump\CrackMe.exe.il" "C:\Users\InsYst3m~\Source\Repos\Debugging\CrackMe\CrackMe.exe" 

change brtrue.s on brfalse.s
use ilasm to compile new exe

Get code cmd:
	cd "C:\Users\InsYst3m~\Source\Repos\Debugging\Console\bin\Debug\netcoreapp3.1\runtimes\win-x64\native"
	ilasm /exe /pdb /debug "C:\Users\InsYst3m~\Source\Repos\Debugging\CrackMe\Dump\CrackMe.exe.il"
	
check Forced-CrackMe.exe
