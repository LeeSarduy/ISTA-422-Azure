What is Azure Blob Service?
The Azure Blob service gives you the ability to store files and access them from anywhere in the world by using URLs, the REST interface, or one of the Azure SDK storage client libraries. Storage client libraries are available for multiple languages, including .NET, Node.js, Java, PHP, Ruby, and Python.
What do you have to do to create Azure Blob Service?
To use the Blob service, you have to create a storage account.
What are some common scenarios where file share can be used?
Many on-premises applications use file shares; this makes it easier to migrate those applications that share data to Azure. If you mount the file share to the same drive letter that the on-premises application uses, the part of your application that accesses the file share should work without any changes.
Configuration files can be stored on a file share and accessed by multiple VMs.
What is Locally Rendundant Storage?
Locally Redundant Storage (LRS) Azure Storage provides high availability by ensuring that three copies of all data are made synchronously before a write is deemed successful. These copies are stored in a single facility in a single region. The replicas reside in separate fault domains and upgrade domains. This means the data is available even if a storage node holding your data fails or is taken offline to be updated.
Describe Azure Key Vault.
Azure Key Vault Azure Key Vault helps safeguard cryptographic keys and secrets used by Azure applications and services. You could store your storage account keys in an Azure Key Vault. What does this do for you? While you can’t control access to the data objects directly using Active Directory, you can control access to an Azure Key Vault using Active Directory. This means you can put your storage account keys in Azure Key Vault and then grant access to them for a specific user, group, or application.
What is Azure Disc Encryption?
This is another new feature that is currently in preview. This feature allows you to specify that the OS and data disks used by an IaaS VM should be encrypted. For Windows, the drives are encrypted with industry-standard BitLocker encryption technology. For Linux, encryption is performed using DMCrypt.
What is Client Size Encryption? The data is encrypted by the application and sent across the wire to be stored in the storage account. When retrieved, the data is decrypted by the application. Because the data is stored encrypted, this is encryption at rest.
What are some of the things you can do with AzCopy?
Upload blobs from the local folder on a machine to Azure Blob storage.Upload files from the local folder on a machine to Azure File storage. Copy blobs from one container to another in the same storage account.
Name three options in the settings blade?
Access keys, configuration, Custom Domain.
How much did you learn from reading this chapter? A lot.