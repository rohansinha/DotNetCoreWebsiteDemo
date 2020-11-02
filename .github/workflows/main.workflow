name: CqlTest

on:
  pull_request:
    branches: [ master ]

env:
  AZURE_WEBAPP_NAME: sdlcdemo2        # set this to your application's name
  AZURE_WEBAPP_PACKAGE_PATH: '.'      # set this to the path to your web app project, defaults to the repository root
  DOTNET_VERSION: '3.1.301'           # set this to the dot net version to use
  
jobs:
  test-codeql:

    runs-on: ubuntu-latest

    steps:
      # Checkout the repo
      - uses: actions/checkout@v2
      
      # Setup .NET Core SDK
      - name: Setup .NET Core
        uses: actions/setup-dotnet@v1
        with:
          dotnet-version: ${{ env.DOTNET_VERSION }}        
      
      # Test CodeQL
      - name: Run PowerShell
        uses: actions/
