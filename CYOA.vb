Module CYOA
    'Arlo Russell
    '10/17/23
    'Choose Your Own Adventure (Not anymore)
    'Please note: I'm a writer, this is going to be extremely in depth and wordy

    'Clean up dialouge to change colors better - Done
    'Replace 'You' with 'Kanata' - Doing
    Sub Main()
        Console.WriteLine("     Since this is done. I'm channging it to fit my character")
        Console.WriteLine("     Before we begin, I have some context about him.")
        Console.WriteLine("     Kanata was once a commander in his home's military and fought in a war many years ago.")
        Console.WriteLine("     During this war, he fought a man named Rhyes, a commander for the other side. Kanata won against him in a duel, leaving him the only one standing.")
        Console.WriteLine("     When he returned, he started seeing Rhyes around him. He were being haunted by him, and Rhyes is not a quiet man.")
        Console.WriteLine("     In the years since, he has grown acustomed to Rhyes'...company and lack of 'off switch' but Kanata has never responded to him.")
        Console.WriteLine("     (Press enter to begin)")
        Console.ReadLine()

        Console.WriteLine("     Kanata moved around his small village home, making breakfast, cleaning up a bit, the basic morning tasks")
        Console.WriteLine("     As he did this, he could see Rhyes move in and out of his vision as he looked around Kanata's home")
        Console.WriteLine("     He seems to always be interested in the devices and knick knacks Kanata had around his kitchen and often asks queations about them")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("     ""Hey!""")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write(" He calls out to get Kanata's attention, ")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("""What's this?""")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("     Kanata looked over and saw that Rhyes' was pointing a small scuplture of a cat on a shelf")
        Console.Write("     Does he answer Rhyes?")
        Dim input As String = yesOrNo()
        Console.WriteLine()
        If input = "Y" Then
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("     ""It's a sculpture one of my soldiers made during our down time.""")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("     The ghost jumped at the sound of Kanata's voice, having not expected an answer.")
            Console.WriteLine("     He smiled and continued his idle chatter and asking more quetions, not caring if he got an answer or not.")
            Console.WriteLine("     During this, Kanata cought a mention of wanting to go to the forest nearby. Something about animals and plants")
            Console.Write("     Do you go to forest as the ghost wants?")
            input = yesOrNo()
            Console.WriteLine()
            If input = "Y" Then
                Console.WriteLine("     You grab your coat from next to the door and leave towards the forest.")
                Console.WriteLine("     Rhyes smiles at you and you notice that he seems to bounce as he 'walks' with you.")
                plantPath()
            Else
                Console.WriteLine("     You don't grace him with an answer this time and continue your morning tasks")
                Console.WriteLine("     The ghost seems a little disappointed that you didn't listen to him, though he isn't surprised.")
                Console.WriteLine("     Upon finishing your tasks, you feel a cold hand grip your wrist and you start getting pulled out the door.")
                Console.ForegroundColor = ConsoleColor.Green
                Console.Write("     ""Woods"" ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("is the only answer you get to what's going on")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("     He lets go of your wrist when you begin walking down the trail")
                plantPath()
                'This basically just means that if you answer him, you end up in the forest
            End If
        Else
            Console.WriteLine("     The ghost isn't surprised by your silence and continues looking around the kitchen.")
            Console.WriteLine("     He does ask about other things on the shelves but you don't answer him.")
            Console.Write("     Do you wish to go to the woods (Y) or market (N)?")
            input = yesOrNo()
            Console.WriteLine()
            If input = "Y" Then
                Console.WriteLine("     You grab your coat and begin making your way towards the nearby forest")
                plantPath()
            Else
                Console.WriteLine("     You grab your money and coat and begin your walk to the market.")
                Console.WriteLine("     You can see the ghost in the corner of your eye. He looks to be pouting as he follows you.")
                Console.WriteLine("     While you look through the differnt produce in the stalls, Rhyes starts picking up differnt items, earning a few shocked gasps at the now ""floating"" fruit")
                Console.WriteLine("     You can hear his laughs as a young child begins to chase the flying fruit around the market.")
                Console.Write("     Do you tell him to stop")
                input = yesOrNo()
                Console.WriteLine()
                If input = "Y" Then
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.WriteLine("     ""Knock it off!""")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("     Some people around you give you weird looks as you appear to be talkig to no one.")
                    Console.WriteLine("     Rhyes sighs and hands the fruit to the kid.")
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("     ""You're no fun.""")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("     He makes his way back over to you and starts pointing out differnt foods he wants you to grab.")
                    Console.ReadLine()
                    Console.WriteLine("     This concludes your adventure for now.")
                Else
                    Console.WriteLine("     You simply watch as Rhyes continues to allow the younger children in the market chase after him.")
                    Console.WriteLine("     Some adults are also chasing after him shouting about a theif.")
                    Console.WriteLine("     All in all, a very ammusing sight")
                    Console.ReadLine()
                    Console.WriteLine("     This concludes your adventure for now.")

                End If
            End If

        End If

    End Sub
    'Yes No Function
    Function yesOrNo() As String
        Dim inp
        Do
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.Write(" Y or N? ")
            inp = Console.ReadLine()
            inp = inp.Trim.ToUpper

            If inp <> "Y" AndAlso inp <> "N" Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("!!Invalid Input!!")
            End If

        Loop While inp <> "Y" AndAlso inp <> "N"
        Console.ForegroundColor = ConsoleColor.White
        Return inp
    End Function
    'Overly long path that literally started with plants beacuse that's normal
    Sub plantPath()
        Dim input As String
        Console.WriteLine("     The ghost moves along the trail in a zig-zag manner, looking at the different plants along the forest floor.")
        Console.WriteLine("     Suddently, he grabbs you by the hand and pulls you over to a small plant with tall yellow-ish green stalks.")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("     ""Look, this one helps with inflamation around things like stings and bites."" ")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("He points at the leaves around the bottom of the plant, ")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("""What do you call it? If you know.""")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("     Do you respond?")
        input = yesOrNo()
        Console.WriteLine()
        If input = "Y" Then
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("     ""It's Plantain""")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("     He nods excitedly and gets up, dragging you along with him as he points out differnt plants and what they can do in medicine.")
            Console.WriteLine("     You two continue on your walk until the sun begins to get lower in the sky and shadows grow longer.")
            Console.WriteLine("     Do you wish to go back home?")
            input = yesOrNo()
            Console.WriteLine()
            If input = "Y" Then
                Console.WriteLine("     This concludes your adventure.")
            Else
                Console.WriteLine("     Ryhes looks up to the sky and notices the height of the sun.")
                Console.WriteLine("     He turns to you and notices that you dont seem to have any plan to turn back.")
                Console.WriteLine("     You hear a sigh and a cold hand grab your wrist as the ghost drags you back to your home")
                Console.WriteLine("     This concludes your adventure.")
            End If
        Else
            Console.WriteLine("     Rhyes hums at your lack of response")
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write("     ""It's called Plantain, very usefull while camping in the woods.""")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write(" He explains, ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("""My soliders had to use it a lot while fighting on our homeland.""")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("     He stands up and starts to wander away from you, further into the woods and away from the trail.")
            Console.WriteLine("     You debate whether or not you should follow him.")
            Console.Write("     Do you follow him?")
            input = yesOrNo()
            Console.WriteLine()
            If input = "Y" Then 'This option gets a little depressing
                Console.WriteLine("     You follow him through the woods, staying behind him when he stops and leans against a tree")
                Console.WriteLine("     He looks around and his eyes fall on you. The laugh he lets out is dry and humorless.")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("     ""You look crazy, following a ghost through a forest.""")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("     He sighs and turns his face back twards the sky. With the light shinning directly at him, you notice that the tips of his fingers are translucent.")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("     ""You know, I didn't choose to be stuck with you.""")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("     His voice is low as he speaks, making you feel a little unsettled as there is usually an edge of mockery or excitement lacing his words.")
                Console.ForegroundColor = ConsoleColor.Green
                Console.Write("     ""I would've prefered to stay dead."" ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("He states, ")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("""Or atealst be stuck with someone who actually knew me in life""")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("     You contine watching him as he pushes himself off of the tree.")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("     ""So,""")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(" He says, turning towards you, ")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("""I'm going to guess you have questions about me, even if you're often too stubborn to ask them.""")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("     Do you have questions?")
                input = yesOrNo()
                Console.WriteLine()
                If input = "Y" Then
                    questions()
                Else
                    Console.WriteLine("     You shake your head in disagreeance")
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.Write("     ""Really?"" ")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.Write("He pries, ")
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("""I'm sure there's something you want to know""")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("     Are You sure you don't have questions?")
                    yesOrNo()
                    If input = "Y" Then
                        Console.WriteLine("     You shake your head, cnofirming that you have nothing to ask.")
                        Console.WriteLine("     He stares at you in disbelief and confusion.")
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.Write("     ""So you're telling me,"" ")
                        Console.ForegroundColor = ConsoleColor.White
                        Console.WriteLine("He begins, ")
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("""That after living with a literal ghost for year, you have absolutely no questions?""")
                        Console.ForegroundColor = ConsoleColor.White
                        Console.WriteLine("     You nod, much to Rhyes' annoyance.")
                        Console.WriteLine("     You begin to hear the sound of rustling behind you.")
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("     ""Oh great.""")
                        axelwRhyes()
                    Else
                        questions()
                    End If
                End If
            Else
                Console.WriteLine("     You continue on the trail without the annoying ghost.")
                Console.WriteLine("     You begin to hear footsteps behind you as you go.")
                axelnoRhyes()
            End If
        End If
    End Sub

    Sub questions()
        Dim input As String
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("     ""You're right. I do have questions.""")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("     Do you ask about his life (y) or about him being a ghost (n)?")
        input = yesOrNo()
        Console.WriteLine()
        If input = "Y" Then
            'Life TO BE DONE WORK ON IT
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write("     ""Fire Away."" ")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("He smiles and crosses his arms")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("     ""Did you have a family?""")
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write("     ""Woah,"" ")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("He starts, ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("""Deep questions first, I see how it is.""")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("     ""Well...""")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("     He sighs before answering, ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("""No, I did not. Had a very anti military family that decided their beliefs were more important than me.""")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("     ""Oh...wow""")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("     ""Yep. Are you going to ask anymore deep questions about me or something simple?""")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.Write("     ""Not right now,"" ")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("You hum and look up at the tree above, ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write("""I'm going to head back home, I feel like I'm losing more of my sanity the longer I talk to you.""")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.Write("     ""You proably are.""")
            Console.ReadLine()
            Console.WriteLine("     This concludes your adventure for now.")

        Else
            'Ghost
            Console.ForegroundColor = ConsoleColor.Green
            Console.Write("     ""Fire Away."" ")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("A smile pulls at the corners of his mouth")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("     ""Why can you sometimes interact with things and sometimes go right through them?""")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("     The ghost hums and shrugs, ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("""Don't know, just depends on what I want to do.""")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("     ""What do you mean, 'don't know'?!""")
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("     He shrugges again, ")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("""I mean I don't know, it just happens.""")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("     You sigh and run a hand down your face. You go to speak again when Rhyes cuts you off.")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("     ""Shh, I hear someone coming""")
            axelwRhyes()
        End If
    End Sub

    Sub axelwRhyes()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("     You turn around and spot a pale man coming towards you through the woods.")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("     ""Axel? What are you doing here?""")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("     He continues moving towards you but stop suddely. He's looking past you. You turn to see what he's looking at and you realize he's looking directly at Rhyes.")
        Console.WriteLine("     From the look on the ghost's face, he's also realized it.")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("     ""How is he here... That shouldn't be possible...""")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("     ")

        Console.ReadLine()
        Console.WriteLine("     This concludes your adventure for now.")
    End Sub
    Sub axelnoRhyes()
        Console.WriteLine("     Upon hearing the footsteps behind you, you turn to see who's there.")
        Console.WriteLine("     You are met with the sight of a pale man walkihng towards you. He's smiling.")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("     ""Axel?""")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("     He smiles and makes his way next to you, ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("""Commander.""")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("     ""Bit of a suprise to see you here.""")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("     ""I had hoped so, how have you been?""")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("     You smile, ")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("""I've been doing well, what about yourself?""")
        Console.ForegroundColor = ConsoleColor.White

        Console.ReadLine()
        Console.WriteLine("     This concludes your adventure for now.")

    End Sub
End Module
