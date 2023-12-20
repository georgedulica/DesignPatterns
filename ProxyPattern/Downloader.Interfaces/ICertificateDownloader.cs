using ProxyPattern.Models;

namespace ProxyPattern.Downloader.Interfaces;

internal interface ICertificateDownloader
{
    Certificate DownloadCertificate(string certificateName, string company);
}