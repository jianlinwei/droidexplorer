<#
 #
 #
 #>

$commitMessageRegex = "^\[deploy\:(pre-release|draft|release)\]$";

# THIS SHOULD BE MOVED TO THE MATCH SECTION AFTER TESTING.
	# read the publish text file
	if(Test-Path -Path "$env:APPVEYOR_BUILD_FOLDER\.build\publishchangelog.txt") {
		$publishNotes = (Get-Content -Path .\.build\publishchangelog.txt);
		[Environment]::SetEnvironmentVariable("CI_RELEASE_DESCRIPTION", $publishNotes, "Machine")
	}

	if( (!(Test-Path -Path Env:\CI_BUILD_VERSION) -or !(Test-Path -Path Env:\CI_BUILD_REVISION)) -and (Test-Path -Path .\VersionAssemblyInfo.txt) ) {
    $version = (Get-Content -Path .\VersionAssemblyInfo.txt);
		$split = $version.split(".");
		[Environment]::SetEnvironmentVariable("CI_BUILD_VERSION", $version, "Machine")
		[Environment]::SetEnvironmentVariable("CI_BUILD_REVISION", $split[3], "Machine")
	}


# Must come from master branch.
# Must not have a PULL Request Number
# Must match regex
if ( !$env:APPVEYOR_PULL_REQUEST_NUMBER -and ($env:APPVEYOR_REPO_BRANCH -eq "master") -and ($env:APPVEYOR_REPO_COMMIT_MESSAGE -match $commitMessageRegex) ) {
	$env:CI_RELEASE_DESCRIPTION = $env:APPVEYOR_REPO_COMMIT_MESSAGE_EXTENDED
	$env:CI_DEPLOY_NUGET = $true;
  $env:CI_DEPLOY_GITHUB = $true;
  $env:CI_DEPLOY_FTP = $true;
	$env:CI_DEPLOY_WebHook = $true;
	$env:CI_DEPLOY_WebDeploy = $true;
	$env:CI_DEPLOY_CodePlex = $true;
	$env:CI_DEPLOY_WEBAPI_RELEASE = $true;



} else {
	# Do not assign a release number or deploy
  $env:CI_DEPLOY_NUGET = $false;
  $env:CI_DEPLOY_GITHUB = $false;
  $env:CI_DEPLOY_FTP = $false;
	$env:CI_DEPLOY_WebHook = $false;
	$env:CI_DEPLOY_WebDeploy = $false;
	$env:CI_DEPLOY_CodePlex = $true;
	$env:CI_DEPLOY_WEBAPI_RELEASE = $false;



}