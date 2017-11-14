module HelloWorld.Tests.Hello

open HelloWorld.Core.Hello
open NUnit.Framework
open FsUnit

[<Test>]
let shouldSayHello () = Assert.AreEqual("Hello World!", SayHello "World")

[<Test>]
let shouldSayHelloWithFsUnit () = SayHello "World" |> should equal "Hello World!"
