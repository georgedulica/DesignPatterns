using ProxyPattern.Downloader.Interfaces;
using ProxyPattern.Models;

namespace ProxyPattern.Downloader;

public class CertificateDownloader : ICertificateDownloader
{
    public Certificate DownloadCertificate(string certificateName, string company)
    {
        var certificate = new Certificate();
        certificate.Name = certificateName;
        certificate.Company = company;

        Console.WriteLine($"The certificate {certificateName} has been downloaded from {company}");
        return certificate;
    }
}