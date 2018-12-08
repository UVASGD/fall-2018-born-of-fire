﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: FarmerJamenson.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @FarmerJamenson: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
		}

	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;
	public readonly HOOK macros2;
	public readonly DialogueEnder macros3;
	public readonly GlobalVarMacros macros4;

	@FarmerJamenson()
	{
		this.StartPassage = "Getting his attention.";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new HOOK() { Story = this };
		macros3 = new DialogueEnder() { Story = this };
		macros4 = new GlobalVarMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
		passage18_Init();
		passage19_Init();
		passage20_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Getting his attention.

	void passage1_Init()
	{
		this.Passages[@"Getting his attention."] = new StoryPassage(@"Getting his attention.", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("The old man is too engrossed in looking through the wreckage to notice you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Excuse me, sir.\" ", " Greeting", null);
		yield return lineBreak();
		yield return link("\"How do you do?\"", " How I Do", null);
		yield break;
	}


	// .............
	// #2:  Greeting

	void passage2_Init()
	{
		this.Passages[@" Greeting"] = new StoryPassage(@" Greeting", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("\"What do you want?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I am Detective _. I have a few questions about the night of the fire.\" ", " Finally", null);
		yield break;
	}


	// .............
	// #3:  How I Do

	void passage3_Init()
	{
		this.Passages[@" How I Do"] = new StoryPassage(@" How I Do", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("\"How do you think I 'do'? My crops are burned, most of my belongings along with them, and the people responsible are not locked up!\"");
		yield return lineBreak();
		yield return text("\"Now what do you want?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I am Detective _. I have a few questions about the night of the fire.\" ", " Finally", null);
		yield break;
	}


	// .............
	// #4:  Finally

	void passage4_Init()
	{
		this.Passages[@" Finally"] = new StoryPassage(@" Finally", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("\"Ah, finally! Someone with sense who can deal out justice. I'm sorry if I come off as a bit crass. It's been a long couple days.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("So what do you know? ", " Everything!", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #5:  Everything!

	void passage5_Init()
	{
		this.Passages[@" Everything!"] = new StoryPassage(@" Everything!", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("\"Everything! I know who's responsible for this mess, even if that lazy Sheriff doesn't want admit it.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Who? ", " Them College Kids", null);
		yield return lineBreak();
		yield return link("Lazy Sherrif? ", " Oh, yeah.", null);
		yield break;
	}


	// .............
	// #6:  Them College Kids

	void passage6_Init()
	{
		this.Passages[@" Them College Kids"] = new StoryPassage(@" Them College Kids", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("\"It was them damn college kids! Back on holiday, I imagine. Every time they're home, they hole up in the old church. Stay up all night. Probably doing drugs, or worse!\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"And they were there the night of the fire?\"", "They were there.", null);
		yield break;
	}


	// .............
	// #7:  Oh, yeah.

	void passage7_Init()
	{
		this.Passages[@" Oh, yeah."] = new StoryPassage(@" Oh, yeah.", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("\"Oh, yeah! If he spent as much time doing his job as he does ... this town wouldn't have half the problems it does!\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"That's a bit harsh.\" ", " But true!", null);
		yield return lineBreak();
		yield return link("\"What other problems does this town have?\" ", " Don't get me started...", null);
		yield break;
	}


	// .............
	// #8:  But true!

	void passage8_Init()
	{
		this.Passages[@" But true!"] = new StoryPassage(@" But true!", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("\"But true! \"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"So who do *you* think started the fire?\"", " Them College Kids", null);
		yield break;
	}


	// .............
	// #9:  Don't get me started...

	void passage9_Init()
	{
		this.Passages[@" Don't get me started..."] = new StoryPassage(@" Don't get me started...", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("\"Oh, don't even ge me started!\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Okay, back to the case. Who do you think started the fire?\"", " Them College Kids", null);
		yield break;
	}


	// .............
	// #10: They were there.

	void passage10_Init()
	{
		this.Passages[@"They were there."] = new StoryPassage(@"They were there.", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("\"Yea, they were there alright. Woulda woken me up if I'd been sleepin'. I went over there wit' my Bessie to tell 'em to bug off. \"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Bessie?\"", "Ma gun.", null);
		yield return lineBreak();
		yield return link("\"And did they?\"", "Saw me coming", null);
		yield return lineBreak();
		yield return link("\"You weren't sleeping?\"", "Out for a smoke.", null);
		yield break;
	}


	// .............
	// #11: Saw me coming

	void passage11_Init()
	{
		this.Passages[@"Saw me coming"] = new StoryPassage(@"Saw me coming", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("\"Must've seen me comin' 'cause they was already boltin' out the front door afore I was ten paces from the back.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"How long after that did the fire start?\"", "Dunno", null);
		yield break;
	}


	// .............
	// #12: Ma gun.

	void passage12_Init()
	{
		this.Passages[@"Ma gun."] = new StoryPassage(@"Ma gun.", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("The man gestures to a shotgun resting against one of the remaining walls.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"So what happened?\"", "Saw me coming", null);
		yield break;
	}


	// .............
	// #13: Out for a smoke.

	void passage13_Init()
	{
		this.Passages[@"Out for a smoke."] = new StoryPassage(@"Out for a smoke.", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("\"Out for a midnight smoke. I have insomnia, y'see.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"So what happened?\"", "Saw me coming", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"So who's Bessie?\"", "Ma gun.", null);
		yield break;
	}


	// .............
	// #14: Dunno

	void passage14_Init()
	{
		this.Passages[@"Dunno"] = new StoryPassage(@"Dunno", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("\"I couldn't tell ye. I went back home to get some sleep. Woke up to the smell of smoke.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"If these students left, then why do you think they started the fire?\"", "Could be anything.", null);
		yield return lineBreak();
		yield return lineBreak();
		yield break;
	}


	// .............
	// #15: Could be anything.

	void passage15_Init()
	{
		this.Passages[@"Could be anything."] = new StoryPassage(@"Could be anything.", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("\"Mighta jus' dropped whatever they was smokin'. Mighta done it for kicks. How should I know?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Do you know where I might find these students? Any names, or addresses?\"", "Info", null);
		yield break;
	}


	// .............
	// #16: Info

	void passage16_Init()
	{
		this.Passages[@"Info"] = new StoryPassage(@"Info", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		yield return text("\"As a matter o' fact, I do! This ain't the first time I've had to report this bunch. Just the first time they burnt the place to the ground!\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("In quick procession, the old man gives you the names, addresses, and familial relations of each of his susspects.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Thank you for your help. Have a nice day.\"", "No", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Do you have a place to stay for the night?\"", "Don't worry", null);
		yield break;
	}


	// .............
	// #17: No

	void passage17_Init()
	{
		this.Passages[@"No"] = new StoryPassage(@"No", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return text("\"No, thank you! I'll be very happy to see these hooligans behind bars.\"");
		yield return lineBreak();
		yield return lineBreak();
		macros3.EndDialogue("sdgadf");
		yield break;
	}


	// .............
	// #18: Don't worry

	void passage18_Init()
	{
		this.Passages[@"Don't worry"] = new StoryPassage(@"Don't worry", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		yield return text("\"Don't you worry 'bout me. I've got family all over. One of em'll take me in.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Well, good luck. Thank you for your help.\" ", "No", null);
		yield break;
	}


	// .............
	// #19: Leave

	void passage19_Init()
	{
		this.Passages[@"Leave"] = new StoryPassage(@"Leave", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		macros3.ChangeScene("Demo_End");
		yield break;
	}


	// .............
	// #20: End

	void passage20_Init()
	{
		this.Passages[@"End"] = new StoryPassage(@"End", new string[]{  }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		macros3.EndDialogue("Blease");
		yield break;
	}


}