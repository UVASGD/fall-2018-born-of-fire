﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Lake.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Lake: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("haste", () => this.@haste, val => this.@haste = val);
		}

		public StoryVar @haste;
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

	@Lake()
	{
		this.StartPassage = "Start";

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
	}

	// ---------------
	#endregion

	// .............
	// #1: Start

	void passage1_Init()
	{
		this.Passages[@"Start"] = new StoryPassage(@"Start", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("You open your eyes, a massive headache right under your forehead.");
		yield return lineBreak();
		yield return text("Your body aches, and feels as though it was stretched through a grate.");
		yield return lineBreak();
		yield return text("Lifting your chest off the ground, propped up by your elbows, you look forward, trying not to turn your head and provoke your nasty migraine.");
		yield return lineBreak();
		yield return text("Around you is a small clearing. Dead twigs and leaves litter the ground.");
		yield return lineBreak();
		yield return text("You hear shouts in the distance.");
		yield return lineBreak();
		yield return link("Stay down.", "StayDown", null);
		yield return lineBreak();
		yield return link("Force yourself up.", "GetUp", null);
		yield break;
	}


	// .............
	// #2: StayDown

	void passage2_Init()
	{
		this.Passages[@"StayDown"] = new StoryPassage(@"StayDown", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("You let your back fall back to the dirt, landing a little bit harder than you intended.");
		yield return lineBreak();
		yield return text("Your head jars and your vision spins for a brief moment.");
		yield return lineBreak();
		yield return text("The sounds of crunching leaves and snapping twigs suddenly becomes very apparent growing ever louder and ever more present.");
		yield return lineBreak();
		yield return text("A figure of a man runs over you, their bounding legs seemingly stepping right through you.");
		yield return lineBreak();
		yield return text("Torch in hand, the man rushes deeper downhill, the light fading as the gap between you two grows.");
		yield return lineBreak();
		yield return text("Behind you, you hear more footsteps. Dozens, perhaps. In front of you, you see an approaching glow cast off the foliage.");
		yield return lineBreak();
		yield return link("Follow the man.", "FollowMan", null);
		yield return lineBreak();
		yield return link("Look behind you.", "LookBehind", null);
		yield break;
	}


	// .............
	// #3: GetUp

	void passage3_Init()
	{
		this.Passages[@"GetUp"] = new StoryPassage(@"GetUp", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("Shifting your weight onto one arm, you turn and lift your body off the ground, knees bending then extending as you stand upright.");
		yield return lineBreak();
		yield return text("Your legs stumble in place for a short spell as the blood rushes away from the back of your head and down to your legs.");
		yield return lineBreak();
		yield return text("Your head is aching terribly, and your vision goes grey briefly before the clouds clear from your sight.");
		yield return lineBreak();
		yield return text("As your eyes clear, so do your ears, and you're suddenly aware of the loud crunch of foliage, perhaps only several feet behind you.");
		yield return lineBreak();
		yield return text("A hand sprouts from your chest, then a fire, then a head, then all at once, a man, running downhill, torch in hand, passing right through you as if you were a spirit. The crunch of leaves grows more distant as the man disappears from view.");
		yield return lineBreak();
		yield return text("Behind you, you hear more footsteps approaching, and the glow of torchlight reflected off the leaves glows ever brighter.");
		yield return lineBreak();
		yield return link("Follow the man.", "FollowMan", null);
		yield return lineBreak();
		yield return link("Look behind you.", "LookBehind", null);
		yield break;
	}


	// .............
	// #4: FollowMan

	void passage4_Init()
	{
		this.Passages[@"FollowMan"] = new StoryPassage(@"FollowMan", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		Vars.haste  = true;
		yield return lineBreak();
		yield return text("You put your feet into motion and run after the man, your head beating as if it was your heart.");
		yield return lineBreak();
		yield return text("Over roots, around rocks, and under branches, you step into a clearing.");
		yield return lineBreak();
		yield return text("In front of you, a glistening lake beset by moonlight.");
		yield return lineBreak();
		yield return text("By the shore, a man frantically waving his arms towards the water.");
		yield return lineBreak();
		yield return link("Move in for a closer look.", "MoveCloser", null);
		yield return lineBreak();
		yield return link("Catch your breath but observe from afar.", "WatchFar", null);
		yield break;
	}


	// .............
	// #5: LookBehind

	void passage5_Init()
	{
		this.Passages[@"LookBehind"] = new StoryPassage(@"LookBehind", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		Vars.haste  = false;
		yield return lineBreak();
		yield return text("A crowd of people swings into your vision.");
		yield return lineBreak();
		yield return text("All running, all carrying lanterns and torches, shouting frantically.");
		yield return lineBreak();
		yield return text("You make out the words \"Lake!\" and \"Save her!\"");
		yield return lineBreak();
		yield return link("Follow the crowd.", "FollowCrowd", null);
		yield return lineBreak();
		yield return link("Stay put.", "Stay", null);
		yield break;
	}


	// .............
	// #6: MoveCloser

	void passage6_Init()
	{
		this.Passages[@"MoveCloser"] = new StoryPassage(@"MoveCloser", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("As you move closer, you spot a flurry of splashes, about thirty feet from shore.");
		yield return lineBreak();
		if(Vars.haste) {
			yield return text("The man, panic in his eyes, fixated on the water, gazing helplessly at the sight of a drowning girl. He must not know how to swim.");
		}
		yield return lineBreak();
		if(! Vars.haste) {
			yield return text("The crowd lines the shore, pure panic and dread in their eyes, gazing helpessly at the sight of a drowning girl. They must not know how to swim.");
		}
		yield return lineBreak();
		yield return link("Jump in and save the child.", "Swim", null);
		yield return lineBreak();
		yield return link("Stay put.", "Stay", null);
		yield break;
	}


	// .............
	// #7: WatchFar

	void passage7_Init()
	{
		this.Passages[@"WatchFar"] = new StoryPassage(@"WatchFar", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		if(Vars.haste) {
			yield return text("Behind you, a herd of people rush to the shore. The man continues to wave frantically at the water, and you can make out the words \"Help! Help!... Drowning!\"");
		}
		yield return lineBreak();
		if(! Vars.haste) {
			yield return text("You gaze at the gathering of what appear to be villagers, clad in ragged clothes, worn doublets, and frayed dresses. They are clamoring frantically, shouting over one another. Through the distant commotion, you can faintly make out the word \"Help!\".");
		}
		yield return lineBreak();
		yield return link("Run to shore and see what's going on", "MoveCloser", null);
		yield return lineBreak();
		yield return link("Stay put.", "Stay", null);
		yield break;
	}


	// .............
	// #8: FollowCrowd

	void passage8_Init()
	{
		this.Passages[@"FollowCrowd"] = new StoryPassage(@"FollowCrowd", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("You put your feet into motion and run after the crowd, your head beating as if it was your heart.");
		yield return lineBreak();
		yield return text("Over roots, around rocks, and under branches, you step into a clearing.");
		yield return lineBreak();
		yield return text("In front of you, a glistening lake beset by moonlight.");
		yield return lineBreak();
		yield return text("By the shore, a herd of people frantically waving their arms towards the water.");
		yield return lineBreak();
		yield return link("Move in for a closer look.", "MoveCloser", null);
		yield return lineBreak();
		yield return link("Catch your breath but observe from afar.", "WatchFar", null);
		yield break;
	}


	// .............
	// #9: Stay

	void passage9_Init()
	{
		this.Passages[@"Stay"] = new StoryPassage(@"Stay", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("Your vision recedes into the distance, zooming out like a high power lens, and you feel a phantom force tug at your back.");
		yield return lineBreak();
		yield return text("One pull, then another, then a lurching familiar feeling of being spaghettified.");
		yield return lineBreak();
		yield return text("Visions flash before your eyes: a lake, a drowning girl, a forest of flames watching from the shore.");
		yield return lineBreak();
		yield return link("Black out.", "BlackOut", null);
		yield break;
	}


	// .............
	// #10: BlackOut

	void passage10_Init()
	{
		this.Passages[@"BlackOut"] = new StoryPassage(@"BlackOut", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		macros3.ChangeScene("Credits");
		yield break;
	}


	// .............
	// #11: Swim

	void passage11_Init()
	{
		this.Passages[@"Swim"] = new StoryPassage(@"Swim", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("You dive into the lake, plunging into the water. A frigid grasp takes a hold of your body, sapping away at your motion. You feel as if your limbs were strapped to stone weights. You manage to find the strength to gasp for air as you move your arms into a weak breaststroke.");
		yield return lineBreak();
		if(Vars.haste) {
			yield return text("You reach the flailing girl, who is struggling to keep her head above the water, and extend your arm out to keep her afloat. How you will find the strength to make it back to shore is an afterthought. Your arm goes out... and phases straight through her body.");
		}
		yield return lineBreak();
		if(! Vars.haste) {
			yield return text("You swim for what seems like an eternity, and raise your head up for air");
		}
		yield return lineBreak();
		yield return text("Where the girl was, you see only a stream of bubbles, boiling to the surface with one final breath. Then, it stops.");
		yield return lineBreak();
		yield return link("... ", "Stay", null);
		yield break;
	}


}