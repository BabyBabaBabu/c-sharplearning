dotnet run
if ($LASTEXITCODE -eq 0) {
    <# Action to perform if the condition is true #>
    Write-Host "Execution Successful!"
}
else {
    <# Action when all if and elseif conditions are false #>
    Write-Host "Execution Failed"
}

Write-Host "Return Value = "$LASTEXITCODE