
$imagen = "sl{0}.jpg"
$wc = New-Object System.Net.WebClient

for($i=1; $i -le 46; $i++){
 $nombreImagen = [string]::Format($imagen,$i)
 $url = "https://res.infoq.com/presentations/bdd-specflow-cucumber/en/slides/" + $nombreImagen
 
 [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
 Invoke-WebRequest $url -OutFile $nombreImagen
}