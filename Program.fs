module Program

  open shiiitty.code

  [<``💩``; ``💩``; ``💩``>]
  let loop () =
     for i in 1..10 do printfn "%A" i

  [<EntryPoint>]
  let main _ =
      loop()
      0
