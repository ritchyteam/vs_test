$a = get-process TestVSSolution -ErrorAction SilentlyContinue
if($a){
"Application TestVSSolution is running. Waiting."
$a.waitforexit()
"Application TestVSSolution has stopped running."
}