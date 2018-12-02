﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: PrologueOrphanageScene.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @PrologueOrphanageScene: Cradle.StoryFormats.Harlowe.HarloweStory
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
	public readonly DialogueEnder macros2;

	@PrologueOrphanageScene()
	{
		this.StartPassage = "Outside the Orphanage";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new DialogueEnder() { Story = this };

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
	}

	// ---------------
	#endregion

	// .............
	// #1: Outside the Orphanage

	void passage1_Init()
	{
		this.Passages[@"Outside the Orphanage"] = new StoryPassage(@"Outside the Orphanage", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("\"Hey there,\" says the fireman, in a low grumbly voice. \"Sheriff told me you'd be coming by to take a look. Not much to look at, though.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Can you tell me much about what happened?\" ", " Scene 2", null);
		yield break;
	}


	// .............
	// #2:  Scene 2

	void passage2_Init()
	{
		this.Passages[@" Scene 2"] = new StoryPassage(@" Scene 2", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("\"I'll be honest, we're not too sure. Half the town was burning down that night, you know? Must have spread to the orphanage somehow.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I thought the sheriff said it was a gas leak that started the fire?\" ", " Scene 3", null);
		yield break;
	}


	// .............
	// #3:  Scene 3

	void passage3_Init()
	{
		this.Passages[@" Scene 3"] = new StoryPassage(@" Scene 3", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("The fireman puts up his hands and shrugs.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"The sheriff says a lot of things. All I know for sure is that the whole place burned down.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("He looks towards the burned shell of a building behind him, and then looks back at you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"Want a tour?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Why not?\" ", " Scene 4", null);
		yield break;
	}


	// .............
	// #4:  Scene 4

	void passage4_Init()
	{
		this.Passages[@" Scene 4"] = new StoryPassage(@" Scene 4", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("Following behind the fireman, you slowly make your way towards the orphanage and stop on the front porch. Soft and flaky ashes give way under your feet.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"Building is in rough shape,\" says the fireman. \"Surprised the entire thing hasn't given out yet. Still, can't risk taking you inside.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Sounds sane to me.\" ", " Scene 5", null);
		yield return lineBreak();
		yield return link("\"Sure you can't make an exception?\" ", " Scene 5.1", null);
		yield break;
	}


	// .............
	// #5:  Scene 5

	void passage5_Init()
	{
		this.Passages[@" Scene 5"] = new StoryPassage(@" Scene 5", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("\"You seem to have your head in the right place,\" the fireman responds with a chuckle. \"Can't say the same for those government folk that came by a few weeks ago to check the place out.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Government folk?\" ", " Scene 6", null);
		yield break;
	}


	// .............
	// #6:  Scene 5.1

	void passage6_Init()
	{
		this.Passages[@" Scene 5.1"] = new StoryPassage(@" Scene 5.1", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("\"Sorry,\" he grumbles. \"Can't do that.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Anything else I should know about?\" ", " Scene 5.11", null);
		yield break;
	}


	// .............
	// #7:  Scene 5.11

	void passage7_Init()
	{
		this.Passages[@" Scene 5.11"] = new StoryPassage(@" Scene 5.11", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("\"Hmm...Can't really think of much more to say. Those other government folk that came by asked all the same questions you're asking now. Can't you just get the records from them?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Government folk? Are you saying some other agents came by?\" ", "  Scene 6", null);
		yield break;
	}


	// .............
	// #8:  Scene 6

	void passage8_Init()
	{
		this.Passages[@" Scene 6"] = new StoryPassage(@" Scene 6", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("The fireman gives you a puzzled look.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"Yeah, two guys stopped by to check out the orphanage. Said it was for insurance or something. I thought they were with you.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"What did they look like?\" ", " Scene 7", null);
		yield break;
	}


	// .............
	// #9:   Scene 6

	void passage9_Init()
	{
		this.Passages[@"  Scene 6"] = new StoryPassage(@"  Scene 6", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("The fireman gives you a puzzled look.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"Yeah, two guys stopped by to check out the orphanage. Said it was for insurance or something. I thought they were with you.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"What did they look like?\" ", " Scene 7", null);
		yield break;
	}


	// .............
	// #10:  Scene 7

	void passage10_Init()
	{
		this.Passages[@" Scene 7"] = new StoryPassage(@" Scene 7", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("\"Let's see...Pretty tall, I guess. Maybe 6'2\" and 6'3\". They were wearing dark black suits, you know, like government-type. Didn't say too much, but they were basically asking the same things you were asking. Really wanted to look inside too.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Did you let them?\" ", " Scene 8", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #11:  Scene 8

	void passage11_Init()
	{
		this.Passages[@" Scene 8"] = new StoryPassage(@" Scene 8", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("\"I'm no fool,\" the fireman grumbles. \"You can show my all the shiny ID you want, I ain't gonna let you in a house that could collapse at any second.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Alright. Thanks for all the help. Is there anything else I should know before I go?\" ", " Scene 9", null);
		yield break;
	}


	// .............
	// #12:  Scene 9

	void passage12_Init()
	{
		this.Passages[@" Scene 9"] = new StoryPassage(@" Scene 9", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("The fireman hesitates, but eventually nods.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"I wasn't going to show this to anyone, but you seem like an honest guy. Follow me.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("*Follow him* ", " Scene 10", null);
		yield break;
	}


	// .............
	// #13:  Scene 10

	void passage13_Init()
	{
		this.Passages[@" Scene 10"] = new StoryPassage(@" Scene 10", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("The fireman takes you to the side of the orphanage and stops, then points at the ground.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"Look there,\" he says. \"It looks like ash, but take a closer look...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"...Bones?\" ", " Scene 11", null);
		yield break;
	}


	// .............
	// #14:  Scene 11

	void passage14_Init()
	{
		this.Passages[@" Scene 11"] = new StoryPassage(@" Scene 11", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("\"That's what they look like. Don't worry yourself too much, they ain't human. They're from some dogs and cats, from what I judge. Maybe a squirrel too.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"There are a lot of bones. Any idea why they would be here?\" ", " Scene 12", null);
		yield break;
	}


	// .............
	// #15:  Scene 12

	void passage15_Init()
	{
		this.Passages[@" Scene 12"] = new StoryPassage(@" Scene 12", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("\"No clue,\" the fireman says. \"It's your job to figure this out, ain't it?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I guess it is, isn't it?\" ", " Scene 13", null);
		yield break;
	}


	// .............
	// #16:  Scene 13

	void passage16_Init()
	{
		this.Passages[@" Scene 13"] = new StoryPassage(@" Scene 13", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		macros2.EndDialogue(" ");
		yield break;
	}


}