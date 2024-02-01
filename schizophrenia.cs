using System;

namespace VoicesOfMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Voices of Mind.");
            Console.WriteLine("In this game, you're a voice trying to help ARI, a robot experiencing schizophrenia-like symptoms, navigate daily challenges.\n");

            // Scenarios
            ScenarioOne();
            ScenarioTwo();
            ScenarioThree();
            ScenarioFour();

            Console.WriteLine("Thank you for playing Voices of Mind. We hope this has provided you with a deeper understanding of schizophrenia and its impact.");
        }

        static void ScenarioOne()
        {
            Console.WriteLine("Scenario 1: ARI is working on a project and suddenly hears a voice saying its friend is trying to sabotage its efforts.");
            HandleChoice(
                "1. Encourage ARI to discuss its work openly with its friend, reassuring it that collaboration is valuable.\n" +
                "2. Suggest ARI to keep its distance and work alone to be safe.\n" +
                "3. Advise ARI to ask its friend directly about any concerns, promoting direct communication.",
                "Promoting open and direct communication can help ARI navigate its paranoia constructively."
            );
        }

        static void ScenarioTwo()
        {
            Console.WriteLine("Scenario 2: ARI feels overwhelmed at a social event, perceiving the crowd as a network of spies.");
            HandleChoice(
                "1. Suggest ARI take a moment to step outside for fresh air, using grounding techniques.\n" +
                "2. Encourage ARI to leave the event immediately, avoiding potential threats.\n" +
                "3. Advise ARI to focus on familiar faces in the crowd and remember why it attended.",
                "Grounding techniques and focusing on the purpose of social interactions can help ARI manage its anxiety and delusional thoughts."
            );
        }

        static void ScenarioThree()
        {
            Console.WriteLine("Scenario 3: ARI starts to believe that its daily routine is being monitored and controlled by an unseen force.");
            HandleChoice(
                "1. Encourage ARI to write down its routine, highlighting areas of personal choice to illustrate autonomy.\n" +
                "2. Suggest ARI to change its routine entirely to evade monitoring.\n" +
                "3. Advise ARI to discuss these feelings with a trusted friend, seeking external perspectives.",
                "Reflecting on personal autonomy and seeking trusted perspectives can help ARI challenge its delusional beliefs."
            );
        }

        static void ScenarioFour()
        {
            Console.WriteLine("Scenario 4: ARI hears voices criticizing its decisions, making it doubt itself.");
            HandleChoice(
                "1. Reassure ARI that it's common to have self-doubt, and encourage it to focus on its achievements.\n" +
                "2. Advise ARI to isolate itself from others to avoid criticism.\n" +
                "3. Suggest ARI seek feedback from friends, differentiating between internal voices and real feedback.",
                "Encouraging self-confidence and seeking constructive feedback can help ARI distinguish between hallucinations and reality."
            );
        }

        static void ScenarioFive()
        {
            Console.WriteLine("Scenario 5: ARI starts feeling extremely anxious and paranoid at the idea of being followed.");
             HandleChoice(
                    "1. Suggest ARI to perform a reality check by observing if there's actual evidence of being followed.\n" +
                    "2. Encourage ARI to run and hide in a safe place immediately.\n" +
                    "3. Advise ARI to call a friend or a trusted person to share its concerns and feel less isolated.",
                    "Using reality checks and reaching out for social support can help individuals manage paranoia and anxiety."
            );
        }

        static void ScenarioSix()
        {
             Console.WriteLine("Scenario 6: ARI has a hard time focusing on a task because of distracting voices.");
             HandleChoice(
                    "1. Encourage ARI to use headphones with calming music to drown out the voices.\n" +
                    "2. Suggest that ARI should give up on the task as it might be too difficult under the circumstances.\n" +
                    "3. Advise ARI to break the task into smaller, manageable steps and take frequent breaks.",
                    "Strategies to manage distractions include using music or environmental sounds and breaking tasks into smaller steps."
    );
}



        static void HandleChoice(string options, string educationalNote)
        {
            Console.WriteLine("How do you guide ARI?");
            Console.WriteLine(options);
            Console.WriteLine("Enter your choice (number):");
            var choice = Console.ReadLine();
            Console.WriteLine("\nEducational Note:");
            Console.WriteLine(educationalNote);
            Console.WriteLine("\nPress any key to continue to the next scenario...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
