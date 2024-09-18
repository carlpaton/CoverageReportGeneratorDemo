$reportPath = 'report'
$testResultsPath = 'Cover.Tests\TestResults\'

if (Test-Path -Path $reportPath) {
    Remove-Item $reportPath -Recurse -Force
}

if (Test-Path -Path $testResultsPath) {
    Remove-Item $testResultsPath -Recurse -Force
}