﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Storage.Blob;
using Microsoft.Azure.Storage.DataMovement;
using Microsoft.Azure.Storage.File;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Storage.Common
{
    public interface ITransferManager
    {
        /// <summary>
        /// Download an Azure file from Azure File Storage.
        /// </summary>
        /// <param name="sourceFile">The Microsoft.Azure.Storage.File.CloudFile that is the source Azure file.</param>
        /// <param name="destPath">Path to the destination file.</param>
        /// <param name="options">A Microsoft.WindowsAzure.Storage.DataMovement.DownloadOptions object that specifies additional options for the operation.</param>
        /// <param name="context">A Microsoft.WindowsAzure.Storage.DataMovement.TransferContext object that represents
        ///     the context for the current operation.</param>
        /// <param name="cancellationToken">A System.Threading.CancellationToken object to observe while waiting for a task to complete.</param>
        /// <returns>A System.Threading.Tasks.Task object that represents the asynchronous operation.</returns>
        Task DownloadAsync(CloudFile sourceFile, string destPath, DownloadOptions options, SingleTransferContext context, CancellationToken cancellationToken);

        /// <summary>
        /// Download an Azure blob from Azure Blob Storage.
        /// </summary>
        /// <param name="sourceBlob">The Microsoft.Azure.Storage.Blob.CloudBlob that is the source Azure blob.</param>
        /// <param name="destPath">Path to the destination file.</param>
        /// <param name="options">A Microsoft.WindowsAzure.Storage.DataMovement.DownloadOptions object that specifies
        ///     additional options for the operation.</param>
        /// <param name="context">A Microsoft.WindowsAzure.Storage.DataMovement.TransferContext object that represents
        ///     the context for the current operation.</param>
        /// <param name="cancellationToken">A System.Threading.CancellationToken object to observe while waiting for a task
        ///     to complete.</param>
        /// <returns>A System.Threading.Tasks.Task object that represents the asynchronous operation.</returns>
        Task DownloadAsync(CloudBlob sourceBlob, string destPath, DownloadOptions options, SingleTransferContext context, CancellationToken cancellationToken);

        /// <summary>
        /// Upload a file to Azure File Storage.
        /// </summary>
        /// <param name="sourcePath">Path to the source file.</param>
        /// <param name="destFile">The Microsoft.Azure.Storage.File.CloudFile that is the destination Azure file.</param>
        /// <param name="options">An Microsoft.WindowsAzure.Storage.DataMovement.UploadOptions object that specifies
        ///     additional options for the operation.</param>
        /// <param name="context"> A Microsoft.WindowsAzure.Storage.DataMovement.TransferContext object that represents
        ///     the context for the current operation.</param>
        /// <param name="cancellationToken"> A System.Threading.CancellationToken object to observe while waiting for a task
        ///     to complete.</param>
        /// <returns>A System.Threading.Tasks.Task object that represents the asynchronous operation.</returns>
        Task UploadAsync(string sourcePath, CloudFile destFile, UploadOptions options, SingleTransferContext context, CancellationToken cancellationToken);

        /// <summary>
        /// Upload a file to Azure Blob Storage.
        /// </summary>
        /// <param name="sourcePath">Path to the source file.</param>
        /// <param name="destBlob">The Microsoft.Azure.Storage.Blob.CloudBlob that is the destination Azure blob.</param>
        /// <param name="options">An Microsoft.WindowsAzure.Storage.DataMovement.UploadOptions object that specifies
        ///     additional options for the operation.</param>
        /// <param name="context">A Microsoft.WindowsAzure.Storage.DataMovement.TransferContext object that represents
        ///     the context for the current operation.</param>
        /// <param name="cancellationToken">A System.Threading.CancellationToken object to observe while waiting for a task
        ///     to complete.</param>
        /// <returns>A System.Threading.Tasks.Task object that represents the asynchronous operation.</returns>
        Task UploadAsync(string sourcePath, CloudBlob destBlob, UploadOptions options, SingleTransferContext context, CancellationToken cancellationToken);
    }
}
