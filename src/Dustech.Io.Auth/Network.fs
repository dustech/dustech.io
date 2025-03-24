namespace TheGrindOrDie.Auth.Config

[<AutoOpen>]
module Network =
    type NetworkConfiguration =
        { Proxied: bool
          AuthorityInternalUri: string
          AuthorityExternalUri: string
          WebBffInternalUri: string
          WebBffExternalUri: string }
