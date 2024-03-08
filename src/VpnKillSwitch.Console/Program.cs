using System.Net;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

var proxyServer = new ProxyServer(false);

// locally trust root certificate used by this proxy 
//proxyServer.CertificateManager.TrustRootCertificate(true);

// optionally set the Certificate Engine
// Under Mono only BouncyCastle will be supported
//proxyServer.CertificateManager.CertificateEngine = Network.CertificateEngine.BouncyCastle;

proxyServer.BeforeRequest += OnRequest;
proxyServer.BeforeResponse += OnResponse;
proxyServer.ServerCertificateValidationCallback += OnCertificateValidation;
proxyServer.ClientCertificateSelectionCallback += OnCertificateSelection;

var explicitEndPoint = new ExplicitProxyEndPoint(IPAddress.Any, 8000, false)
{
    // Use self-issued generic certificate on all https requests
    // Optimizes performance by not creating a certificate for each https-enabled domain
    // Useful when certificate trust is not required by proxy clients
    //GenericCertificate = new X509Certificate2(Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "genericcert.pfx"), "password")
};

// Fired when a CONNECT request is received
explicitEndPoint.BeforeTunnelConnectRequest += OnBeforeTunnelConnectRequest;

// An explicit endpoint is where the client knows about the existence of a proxy
// So client sends request in a proxy friendly manner
proxyServer.AddEndPoint(explicitEndPoint);

proxyServer.Start();

// Transparent endpoint is useful for reverse proxy (client is not aware of the existence of proxy)
// A transparent endpoint usually requires a network router port forwarding HTTP(S) packets or DNS
// to send data to this endPoint
var transparentEndPoint = new TransparentProxyEndPoint(IPAddress.Any, 8001, false)
{
    // Generic Certificate hostname to use
    // when SNI is disabled by client
    GenericCertificateName = "google.com"
};

proxyServer.AddEndPoint(transparentEndPoint);

//proxyServer.UpStreamHttpProxy = new ExternalProxy() { HostName = "localhost", Port = 8888 };
//proxyServer.UpStreamHttpsProxy = new ExternalProxy() { HostName = "localhost", Port = 8888 };

foreach (var endPoint in proxyServer.ProxyEndPoints)
    Console.WriteLine("Listening on '{0}' endpoint at Ip {1} and port: {2} ",
        endPoint.GetType().Name, endPoint.IpAddress, endPoint.Port);

// Only explicit proxies can be set as system proxy!
proxyServer.SetAsSystemHttpProxy(explicitEndPoint);
proxyServer.SetAsSystemHttpsProxy(explicitEndPoint);

// wait here (You can use something else as a wait function, I am using this as a demo)
Console.Read();

// Unsubscribe & Quit
explicitEndPoint.BeforeTunnelConnectRequest -= OnBeforeTunnelConnectRequest;
proxyServer.BeforeRequest -= OnRequest;
proxyServer.BeforeResponse -= OnResponse;
proxyServer.ServerCertificateValidationCallback -= OnCertificateValidation;
proxyServer.ClientCertificateSelectionCallback -= OnCertificateSelection;

Task OnBeforeTunnelConnectRequest(object sender, TunnelConnectSessionEventArgs e)
{
    //e.DenyConnect = true;
    return Task.CompletedTask;
}

Task OnRequest(object sender, SessionEventArgs e)
{
    return Task.CompletedTask;
}

Task OnResponse(object sender, SessionEventArgs e)
{
    return Task.CompletedTask;
}

Task OnCertificateValidation(object sender, CertificateValidationEventArgs e)
{
    return Task.CompletedTask;
}

Task OnCertificateSelection(object sender, CertificateSelectionEventArgs e)
{
    return Task.CompletedTask;
}

proxyServer.Stop();
