﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: OrphanageTwo.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @OrphanageTwo: Cradle.StoryFormats.Harlowe.HarloweStory
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
	public readonly GlobalVarMacros macros3;

	@OrphanageTwo()
	{
		this.StartPassage = "Orphan at Inn";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new DialogueEnder() { Story = this };
		macros3 = new GlobalVarMacros() { Story = this };

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
	}

	// ---------------
	#endregion

	// .............
	// #1: Orphan at Inn

	void passage1_Init()
	{
		this.Passages[@"Orphan at Inn"] = new StoryPassage(@"Orphan at Inn", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("\"...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("The boy looks at you curiously, but doesn't say anything.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Hey, would you mind if we talked for a bit? I'm a detective from out of town here investigating the fire, and I'd like to ask you some questions.\" ", " 2", null);
		yield break;
	}


	// .............
	// #2:  2

	void passage2_Init()
	{
		this.Passages[@" 2"] = new StoryPassage(@" 2", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("\"Okay...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"So...Why don't we start with a name?\" ", " 3", null);
		yield break;
	}


	// .............
	// #3:  3

	void passage3_Init()
	{
		this.Passages[@" 3"] = new StoryPassage(@" 3", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("\"George,\" he says quietly, as if speaking louder would be a crime.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Right, George. How long have you lived in this town, George?\" ", " 4", null);
		yield break;
	}


	// .............
	// #4:  4

	void passage4_Init()
	{
		this.Passages[@" 4"] = new StoryPassage(@" 4", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("\"I've lived here my whole life,\" George mumbles. \"What's this got to do with your investigation, by the way?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I just wanted to know if you were around when the fire swept across town.\" ", " 5", null);
		yield return lineBreak();
		yield return link("\"Nothing, really, just trying to make small talk.\" ", " 5.5", null);
		yield break;
	}


	// .............
	// #5:  5

	void passage5_Init()
	{
		this.Passages[@" 5"] = new StoryPassage(@" 5", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("\"You should have just asked,\" George says, suddenly impatient. \"Yeah, I was around...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Around the orphanage?\" ", " 6", null);
		yield break;
	}


	// .............
	// #6:  5.5

	void passage6_Init()
	{
		this.Passages[@" 5.5"] = new StoryPassage(@" 5.5", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("\"Oh, sorry...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Despite what he says, George doesn't look very apologetic.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"How old are you, George?\" ", " 5.51", null);
		yield break;
	}


	// .............
	// #7:  6

	void passage7_Init()
	{
		this.Passages[@" 6"] = new StoryPassage(@" 6", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("\"How did you...?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"If you talk to enough people, you hear things. What I hear is that you used to be one of the orphans at the orphanage. Before it burned down, at least.\" ", " 7", null);
		yield break;
	}


	// .............
	// #8:  5.51

	void passage8_Init()
	{
		this.Passages[@" 5.51"] = new StoryPassage(@" 5.51", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("\"Fifteen. Now quit it with the small talk.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"My bad. I'll get more to the point. Were you around when that fire broke out a little while back?\" ", " 5", null);
		yield break;
	}


	// .............
	// #9:  7

	void passage9_Init()
	{
		this.Passages[@" 7"] = new StoryPassage(@" 7", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("\"Yeah, I was an orphan. So what? You gonna arrest me for not having parents?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Calm down, I just want to get to the bottom of what caused this fire.\" ", " 8", null);
		yield break;
	}


	// .............
	// #10:  8

	void passage10_Init()
	{
		this.Passages[@" 8"] = new StoryPassage(@" 8", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("\"Well I can't help you. We're done here.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"But-\" ", " 9", null);
		yield break;
	}


	// .............
	// #11:  9

	void passage11_Init()
	{
		this.Passages[@" 9"] = new StoryPassage(@" 9", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("\"Goodbye.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Leave. ", "EndDia", null);
		yield break;
	}


	// .............
	// #12: EndDia

	void passage12_Init()
	{
		this.Passages[@"EndDia"] = new StoryPassage(@"EndDia", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		macros2.EndDialogue(" ");
		yield break;
	}


}