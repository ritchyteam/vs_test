$a = get-process TestVSSolution

$a.waitforexit()

"Application has stopped running."