using System;

public class DomainController
{
	public DomainController()
	{
	}

    private List<Provider> providers;

    public List<Provider> GetProviders() {


        return new List<Provider>() { new Provider(1, "Alex", "a", "d"), new Provider(2, "Arturs", "a", "d"), new Provider(3, "Allan", "a", "d") };
    }


}
