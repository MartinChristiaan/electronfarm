module Renderer

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Electron
open Node.Exports
open Fable.PowerPack
//


//let mystring = Fs.readFileSync("foo.txt", "utf8")

// let currentpath = Node.Globals.``process``.cwd()
// let files = Fs.readdirSync(!^currentpath)

// let mystring = Fs.readFileSync("foo.txt.txt","utf-8") //files|>Seq.reduce(fun acc elem -> acc + "<p>"  + elem  + "</p>")

// let mydiv = Browser.document.getElementById("myId")

// mydiv.innerHTML <- mystring


type Pet =
    {
        name : string;
        icon : string;
    }




let get_pet () = 
    {name  = "PetName"; icon = "BaseIcon"}



