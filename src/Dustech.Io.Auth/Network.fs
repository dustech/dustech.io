namespace Dustech.Io.Auth.Config

[<AutoOpen>]
module Network =
    type IdpNetworkConfiguration =
        { Proxied: bool
          AuthorityInternalUri: string
          AuthorityExternalUri: string }
