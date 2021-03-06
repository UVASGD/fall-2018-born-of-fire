﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: The_Crawlspace.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @The_Crawlspace: Cradle.StoryFormats.Harlowe.HarloweStory
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

	@The_Crawlspace()
	{
		this.StartPassage = "Untitled Passage 1";

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
	}

	// ---------------
	#endregion

	// .............
	// #1: Untitled Passage

	void passage1_Init()
	{
		this.Passages[@"Untitled Passage"] = new StoryPassage(@"Untitled Passage", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


	// .............
	// #2: Untitled Passage 1

	void passage2_Init()
	{
		this.Passages[@"Untitled Passage 1"] = new StoryPassage(@"Untitled Passage 1", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("The crawlspace is dark. The smell of ash assaults you nostrils. You consider going back up, but then you see it: one of the symbols from the painting, engraved onto a fragment of stone.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Reach for it.", "Reach for it.", null);
		yield break;
	}


	// .............
	// #3: Reach for it.

	void passage3_Init()
	{
		this.Passages[@"Reach for it."] = new StoryPassage(@"Reach for it.", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("You reach for the stone, but the ground falls out from beneath you. You fall for about 15 feet before you hit a hard earthen floor, covered in mushrooms and lichen. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Look around.", "Look around.", null);
		yield break;
	}


	// .............
	// #4: Look around.

	void passage4_Init()
	{
		this.Passages[@"Look around."] = new StoryPassage(@"Look around.", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("All around you are 15-foot pillars of varying width, covered in the same strange symbols you came here looking for, lit by bioluminescent plant life. In between the wider pillars are tunnels, which lead deeper into the earth. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Where am I?\"", "\"Where am I?\"", null);
		yield break;
	}


	// .............
	// #5: ""Where am I?""

	void passage5_Init()
	{
		this.Passages[@"""Where am I?"""] = new StoryPassage(@"""Where am I?""", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("\"I AM WHERE.\" Your voice echoes back at you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Stand up.", "Stand up.", null);
		yield break;
	}


	// .............
	// #6: Stand up.

	void passage6_Init()
	{
		this.Passages[@"Stand up."] = new StoryPassage(@"Stand up.", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("You try to stand up, but you have a concussion from the fall. You instantly collapse and vomit.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Is there somebody here?\"", "\"Is there somebody here?\"", null);
		yield return lineBreak();
		yield return link("\"Who's out there?\"", "\"Who's out there?\"", null);
		yield break;
	}


	// .............
	// #7: ""Is there somebody here?""

	void passage7_Init()
	{
		this.Passages[@"""Is there somebody here?"""] = new StoryPassage(@"""Is there somebody here?""", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("\"THERE IS SOMEBODY HERE\" your voice echoes.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Who's out there?\"", "\"Who's out there?\"", null);
		yield break;
	}


	// .............
	// #8: ""Who's out there?""

	void passage8_Init()
	{
		this.Passages[@"""Who's out there?"""] = new StoryPassage(@"""Who's out there?""", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("\"I AM OUT HERE\"");
		yield return lineBreak();
		yield return text("Still your words, but mixed and matched.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Are you real, or just an echo?\"", "\"Are you real, or just an echo?\"", null);
		yield return lineBreak();
		yield return link("\"Faries?\"", "\"Faries?\"", null);
		yield break;
	}


	// .............
	// #9: ""Are you real, or just an echo?""

	void passage9_Init()
	{
		this.Passages[@"""Are you real, or just an echo?"""] = new StoryPassage(@"""Are you real, or just an echo?""", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("\"I AM REAL\"");
		yield return lineBreak();
		yield return text("\"I AM HERE\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("What are you?", "What are you?", null);
		yield break;
	}


	// .............
	// #10: ""Faries?""

	void passage10_Init()
	{
		this.Passages[@"""Faries?"""] = new StoryPassage(@"""Faries?""", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("\"FARIES\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Did you start the fire?\"", "\"Did you start the fire?\"", null);
		yield break;
	}


	// .............
	// #11: What are you?

	void passage11_Init()
	{
		this.Passages[@"What are you?"] = new StoryPassage(@"What are you?", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("\"I AM WHO IS OUT THERE\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Faries?\"", "\"Faries?\"", null);
		yield break;
	}


	// .............
	// #12: ""Did you start the fire?""

	void passage12_Init()
	{
		this.Passages[@"""Did you start the fire?"""] = new StoryPassage(@"""Did you start the fire?""", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("\"YOU ARE THE FIRE\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"What does that mean?\"", "\"What does that mean?\"", null);
		yield break;
	}


	// .............
	// #13: ""What does that mean?""

	void passage13_Init()
	{
		this.Passages[@"""What does that mean?"""] = new StoryPassage(@"""What does that mean?""", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("You hear giggling and soft footsteps in the dark.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Roll over.", "Roll over.", null);
		yield break;
	}


	// .............
	// #14: Roll over.

	void passage14_Init()
	{
		this.Passages[@"Roll over."] = new StoryPassage(@"Roll over.", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("You roll over.");
		yield return lineBreak();
		yield return text("You find yourself face-to-face with a horrible face. Green skin. Pointed teeth.");
		yield return lineBreak();
		yield return text("\"WHO ARE YOU?\" it says with your voice.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I am a Detective. I'm here to find answers.\"", "\"I am a Detective. I'm here to find answers.\"", null);
		yield return lineBreak();
		yield return link("\"I am a Detective. And you are under arrest on suspicion of arson.\"", "\"I am a Detective. And you are under arrest on suspicion of arson.\"", null);
		yield break;
	}


	// .............
	// #15: ""I am a Detective. I'm here to find answers.""

	void passage15_Init()
	{
		this.Passages[@"""I am a Detective. I'm here to find answers."""] = new StoryPassage(@"""I am a Detective. I'm here to find answers.""", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("\"NO ANSWERS\"");
		yield return lineBreak();
		yield return text("You look down and find that your clothes have caught on fire.");
		yield return lineBreak();
		yield return text("You try to roll over to put it out, but still you can barely move.");
		yield return lineBreak();
		yield return text("Withing seconds, you pass out from the pain.");
		yield return lineBreak();
		yield return link("...", "...", null);
		yield break;
	}


	// .............
	// #16: ""I am a Detective. And you are under arrest on suspicion of arson.""

	void passage16_Init()
	{
		this.Passages[@"""I am a Detective. And you are under arrest on suspicion of arson."""] = new StoryPassage(@"""I am a Detective. And you are under arrest on suspicion of arson.""", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		yield return text("\"YOU ARE FIRE\"");
		yield return lineBreak();
		yield return text("You look down and find that your clothes have caught on fire.");
		yield return lineBreak();
		yield return text("You try to roll over to put it out, but still you can barely move.");
		yield return lineBreak();
		yield return text("Withing seconds, you pass out from the pain.");
		yield return lineBreak();
		yield return link("...", "...", null);
		yield break;
	}


	// .............
	// #17: ...

	void passage17_Init()
	{
		this.Passages[@"..."] = new StoryPassage(@"...", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return text("One week later, you awaken in a hospital. Apparently Old Gary heard your screaming and called for help. The medical report lists a massive head injury, but no burn injuries. The department has taken you off the case, and has in fact dropped the case altogether. The old church was dertermined to be a safty hazard which should have been demolished ages ago.");
		yield return lineBreak();
		yield return text("Is the fairy still out there? Was the fairy ever there at all? You know you had a concussion, but it felt so real. But amid these questions, one haunts you above them all: What did the fairy mean when it uttered the words, in your own voice, \"YOU ARE FIRE\"?");
		yield return lineBreak();
		yield return lineBreak();
		yield return link(".", ".", null);
		yield break;
	}


	// .............
	// #18: .

	void passage18_Init()
	{
		this.Passages[@"."] = new StoryPassage(@".", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		macros3.ChangeScene("Credits");
		yield break;
	}


}