/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class COMMIT4args : XdrAble {
    public offset4 offset;
    public count4 count;

    public COMMIT4args() {
    }

    public COMMIT4args(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        count.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        count = new count4(xdr);
    }

}
} // End of COMMIT4args.cs