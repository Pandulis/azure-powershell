$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzPublicIPAddress.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzPublicIPAddress' {
    It 'CreateExpanded1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentity1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
