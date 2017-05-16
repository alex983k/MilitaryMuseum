using ClassLibrary;
using Login;
using System;
using System.Collections.Generic;

public class ProviderViewModel
{
    private DomainController dc = new DomainController();
    private List<Provider> providers;

    public List<Provider> Providers {
        get {
            if(providers == null) return dc.GetProviders();
            return providers;
        }
    }

    public ProviderViewModel()
    {

    }
}
