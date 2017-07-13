param($installPath)
$source = Get-ChildItem -Directory "$installPath\..\WinFormAnimation.*" | Sort Name -desc | Select -f 1 | % {$_.FullName + "\lib\net35-client\WinFormAnimation.dll"}
if ($source) {
	Write-Host ("Copy " + $source)
	Copy-Item -LiteralPath "$source" -Destination "$installPath\lib\net35-client\WinFormAnimation.dll" -Force -ErrorAction SilentlyContinue
}