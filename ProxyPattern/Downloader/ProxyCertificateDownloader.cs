using ProxyPattern.Downloader.Interfaces;
using ProxyPattern.Models;

namespace ProxyPattern.Downloader;

public class ProxyCertificateDownloader : ICertificateDownloader
{
    private CertificateDownloader certificateDownloader;

    private static Dictionary<string, Certificate> certificateCache = new Dictionary<string, Certificate>();

    public ProxyCertificateDownloader(CertificateDownloader certificateDownloader)
    {
        this.certificateDownloader = certificateDownloader;
    }
    
    public Certificate DownloadCertificate(string certificateName, string company)
    {
        Certificate certificate;
        if (certificateCache.ContainsKey(certificateName))
        {
            certificate = certificateCache.FirstOrDefault(x => string.Equals(x.Key, certificateName)).Value;
            Console.WriteLine("The certificate has already been downloaded");
        }
        else
        {
            certificate = certificateDownloader.DownloadCertificate(certificateName, company);
            certificateCache.Add(certificateName, certificate);
        }

        return certificate;
    }
}