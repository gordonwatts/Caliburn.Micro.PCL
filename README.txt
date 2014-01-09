This library is meant to help make Caliburn.Micro more portable across platforms. Current:
    - Windows Store 8.1
    - Windows Phone 8

What is in here:
    - An INavService that makes INavigateService common between the two.
        Use the WP8 and WS versions to register it (see the WP8 and WS namespaces)
        in the Caliburn.Micro injection container. Then you can put INavService as a
        ctor argument in your view models (or whatever).
    - A NotifyAndSetIfChanged helper to help write Caliburn.Micro properties on ViewModels:
        public string CDSLookupString
        {
            get { return _CDSLookupString; }
            set { this.RaiseAndSetIfChanged(ref _CDSLookupString, value); }
        }
        private string _CDSLookupString;

Generating A Release:

1) Make sure to bump the version number in the nuspec file.
2) nuget pack -symbols .\Caliburn.Micro.Portable.nuspec
3) nuget push .\Caliburn.Micro.Portable.1.0.0-alpha05.nupkg -source https://xxx -apikey XXX