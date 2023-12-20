using ProxyPattern.Downloader;
using ProxyPattern.Downloader.Interfaces;

public class Program
{
    static void Main()
    {
        var firstName = "GoogleCertificate";
        var firstCompany = "Google";        
        var secondName = "FacebookCertificate";
        var secondCompany = "Facebook";        
        var thirdName = "YouTubeCertificate";
        var thirdCompany = "YouTube";

        var certificateDownloader = new CertificateDownloader();
        var proxyCertificateDownloader = new ProxyCertificateDownloader(certificateDownloader);
       
        var firstCertificate = proxyCertificateDownloader.DownloadCertificate(firstName, firstCompany);
        var secondCertificate = proxyCertificateDownloader.DownloadCertificate(secondName, secondCompany);
        var thirdCertificate = proxyCertificateDownloader.DownloadCertificate(thirdName, thirdCompany);

        var duplicateCertificate = proxyCertificateDownloader.DownloadCertificate(firstName, firstCompany);
    }
}