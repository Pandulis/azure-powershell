$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzKeyVaultSecret.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Remove-AzKeyVaultSecret' {
    It 'Delete' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Purge' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
