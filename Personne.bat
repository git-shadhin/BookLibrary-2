C:
cd C:\Program Files (x86)\Microsoft Visual Studio 11.0\VC
call vcvarsall.bat

cd D:\BibliothequeExamen\Bibliotheque
svcutil D:\BibliothequeExamen\Bibliotheque\COUCHEIFAC\bin\Debug\COUCHEIFAC.dll /d:D:\BibliothequeExamen\Bibliotheque
svcutil D:\BibliothequeExamen\Bibliotheque\COUCHEIFAC.ClsIFACPersonne.wsdl D:\BibliothequeExamen\Bibliotheque\*xsd /out:D:\BibliothequeExamen\Bibliotheque\Bibliotheque\Proxies\ClsIFACPersonne.cs /async /ct:System.Collections.Generic.List`1 /r:D:\BibliothequeExamen\Bibliotheque\COUCHEIFAC\bin\Debug\COUCHEBO.dll /n:*,Bibliotheque.Proxies /noConfig

Pause
del D:\BibliothequeExamen\Bibliotheque\*.wsdl
del D:\BibliothequeExamen\Bibliotheque\*.xsd
cd..
Pause