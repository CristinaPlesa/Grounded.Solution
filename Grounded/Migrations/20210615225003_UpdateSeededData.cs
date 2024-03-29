﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Grounded.Migrations
{
    public partial class UpdateSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName" },
                values: new object[] { "Turquoise", "1. Find a quiet and comfortable place to sit and close your eyes. 2. Notice how your breathing and body feel. 3.Now shift your awareness to the sensations you observe in your surroundings. Ask yourself What’s happening outside of my body? Notice what you hear, smell, and feel in your environment. 4. Change your awareness several times from your body to your environment and back again until your anxiety starts to fade.", "https://unsplash.com/photos/dQejX2ucPBs", "https://www.healthline.com/health/anxiety-exercises#mindfulness", "https://open.spotify.com/track/2sANicYotJYrO53QdGHOV5?si=f25fff5a734a495f", "Anxious" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName" },
                values: new object[] { "Violet", "Practice gratitude: It’s pretty common to feel guilty over needing help when you’re coping with challenges, emotional distress, or health concerns. Remember: People form relationships with others to build a community that can offer support. Imagine the situation in reverse. You’d probably want to show up for your loved ones if they needed help and emotional support. Most likely, you wouldn’t want them to feel guilty about their struggles either. There’s nothing wrong with needing help. Life isn’t meant to be faced alone. Replace negative self-talk with self-compassion: A mistake doesn’t make you a bad person — everyone messes up from time to time. Guilt can provoke some pretty harsh self-criticism, but lecturing yourself on how catastrophically you messed up won’t improve things. Sure, you might have to face some external consequences, but self-punishment often takes the heaviest emotional toll. Instead of shaming yourself, ask yourself what you might say to a friend in a similar situation. Perhaps you’d point out good things they’ve done, remind them of their strengths, and let them know how much you value them. You deserve the same kindness. People, and the circumstances they find themselves in, are complex. You may have some culpability for your mistake, but so might the others involved. Reminding yourself of your worth can boost confidence, making it easier to consider situations objectively and avoid being swayed by emotional distress. Remember guilt can work for you: Guilt can serve as an alarm that lets you know when you’ve made a choice that conflicts with your personal values. Instead of letting it overwhelm you, try putting it to work. When used as a tool, guilt can cast light on areas of yourself you feel dissatisfied with. Maybe you struggle with honesty and someone finally caught you in a lie. Perhaps you want to spend more time with your family, but something always gets in the way. Taking action to address those circumstances can set you on a path that’s more in line with your goals. If you feel guilty for not spending enough time with friends, you might make more of an effort to connect. When stress distracts you from your relationship, you might improve the situation by devoting one night a week to your partner. It’s also worth paying attention to what guilt tells you about yourself. Regret over hurting someone else suggests you have empathy and didn’t intend to cause harm. Creating change in your life, then, might involve focusing on ways to avoid making that mistake again. If you tend to feel bad about things you can’t control, it may be beneficial to explore the reasons behind your guilt with the help of a professional. Forgive yourself: Self-forgiveness is a key component of self-compassion. When you forgive yourself, you acknowledge that you made a mistake, like all other humans do. Then, you can look to the future without letting that mistake define you. You grant yourself love and kindness by accepting your imperfect self. Talk to people you trust: People often have a hard time discussing guilt, which is understandable. After all, it’s not easy to talk about a mistake you regret. This means guilt can isolate you, and loneliness and isolation can complicate the healing process. You might worry others will judge you for what happened, but you’ll often find that isn’t the case. In fact, you may find loved ones offer a lot of support. The people who care for you will generally offer kindness and compassion. And sharing unpleasant or difficult feelings often relieves tension. Friends and family can also help you feel less alone by sharing their experiences. Nearly everyone has done something they regret, so most people know what it’s like to feel guilty. Outside perspective can also make a big difference, especially if you’re dealing with survivor guilt or guilt about something you had no control over.", "https://unsplash.com/photos/Vs_zkj1sEHc", "https://www.healthline.com/health/mental-health/how-to-stop-feeling-guilty#talk-to-people", "https://open.spotify.com/track/4GSDkZt7GcmzBWmsMcpaVO?si=f5892c71714d4dc4", "Guilty" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName" },
                values: new object[] { "Orange", "Make Positive Lists: Self-hate is a major component of depression. All sufferers experience this feeling in some capacity. We often tell ourselves that we aren’t good enough at what we want to do, we hate on our appearances or think negatively about our self-worth. The best thing to do when you have these thoughts is to keep a running list in a place where you will always see. You can tack it onto your fridge, tape it to your computer, or fold it in your pocket. Every time you do something that you are proud of, write it down. When someone says something nice about you, write that down! When you are feeling your worst, look at your list of positivity and remember that negativity is transient. Set Long-Term Goals: Stress and anxiety can ruin motivation and cause bouts of inertia that go on for months at a time. To combat the inertia that comes with mental health disorders, set a long-term goal. It might seem like the worst time to take on a huge project, but it’s the exact opposite. Pursuing a long-term goal that you are passionate about will occupy your thoughts with something positive and get you looking forward to the future. You might even enjoy the process of working towards it! Think of the things you’ve wanted to do all your life like picking up a new hobby, getting healthy or pursuing a career. Try not to pick something that will stress you out too much. The goal right now is to get your mind off the feelings of stress and panic that you’ve been experiencing. Identify Triggers: Sufferers of anxiety and depression have triggers. Triggers can be words, emotions or situations that cause them to experience their mental disorder in full-force. Triggers can be anything from rainstorms to abusive situations or words. By recognizing your trigger, you’ll be able to avoid it or prepare for it. In some situations, you may want to slowly expose yourself to it as a form of therapy, but this should never be attempted without a professional therapist. Meditate: One of the best ways to cope with negative emotions is to meditate. Sometimes it can be difficult to pull yourself out of the physical world and relax, but with patience, it can be liberating. Monitor your day and understand when you are likely to experience the most stress. Is it after the morning commute? Arrive to work a few minutes early and meditate. You might experience the most stress after work. Come home, play some relaxing music and take some time to relax and focus your mind. Another great habit is to meditate right before bed. Your body will get ready for sleep and you’ll be more relaxed and prepared for a good night’s rest. If you enjoy meditating, you might want to try incense, candles or practicing hand mudras. Reward Yourself: Every time you complete a goal, reward yourself. Because inertia is so common with depression and anxiety, getting motivated can be tricky. Stay focused on goals with rewards. They can be anything from your favorite meal to a vacation. You have to stay motivated in whatever ways you can and treating yourself isn’t a bad way to do it. Say No To Self-Hate: Self-hate can be an overpowering feeling. We are often so desensitized that we chastise or dismiss ourselves without realizing the ramifications. Saying no to self-hate is a critical part of the healing process. Watch yourself for negative thoughts about your personality, body, strength or worth and then say no to it. Sometimes, it can be hard to say no to these strong voices, but by just saying it, you’ll start to feel yourself growing stronger. Find a Creative Outlet: Studies have shown that most sufferers of anxiety and depression are also highly creative. If you aren’t, you should still try to find a creative outlet. Writing, drawing, painting, cooking, graphic design or crafting are all great ways to unleash your creativity. Engaging in a creative activity is shown to reduce stress and improve mood. While you might not always enjoy creative activities, you might actually find one you like even if it’s making little paper flowers, writing a poem or making graphic art on your laptop!", "https://unsplash.com/photos/CtLx4qCdhf8", "https://fit4mom.com/blog/7-mental-health-exercises-to-reduce-anxiety-and-depression", "https://open.spotify.com/track/25RDHbzKzGSUefENv5uz9M?si=61589008ed6341f2", "Depressed" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 4,
                column: "ResourceExercise",
                value: "It starts with you sitting comfortably, close your eyes and taking a couple of deep breathes. In through your nose (count to 3), out through your mouth (to the count of 3).Now open your eyes and look around you. Name out loud: 5 – things you can see  4 – things you can feel 3 – things you can hear. 2 – things you can smell  1 – thing you can taste.Take a deep breath to end.");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 5,
                columns: new[] { "ResourceExercise", "ResourceName" },
                values: new object[] { "Step 1: Slowly exhale all of the air out of your lungs. Step 2: Inhale slowly and deeply through your nose to the count of four. In this step, count to four very slowly in your head. Step 3: Hold your breath for another slow count of four. Step 4: Exhale through your mouth for the same slow count of four, expelling the air from your lungs and abdomen. Be conscious of the air leaving your lungs", "Fearful" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 6,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "Turquoise", "Vent", "https://declutterthemind.com/guided-meditation/anger/", "https://open.spotify.com/track/20QeXpfRB5GWK46PlXr1In?si=86b09455a29d41b3", "Angry", "In times of great stress or adversity, it's always best to keep busy, to plow your anger and your energy into something positive. -Lee Iacocca" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 7,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "Green", "Guided Imagery", "https://www.health.harvard.edu/mind-and-mood/six-relaxation-techniques-to-reduce-stress", "https://open.spotify.com/track/18ETUDvgfFPonyIjOwRFGu?si=3dc30ea49cff4f00", "Stressed", "When you take the time to cleanse your physical body of accumulated stress and toxicity, you are rewarded with increased vitality and optimal health. -Debbie Ford" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 8,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "FCBF49", "1. Mindfulness of the breath: The breath is a powerful force and when we practice mindful breath meditation, we redirect our attention and thoughts to the breath as it moves through the body, giving ourselves a small break from the incessant chatter of the mind and enabling us to simply be with things as they are at that moment. How to do it: Begin by relaxing the body and directing your awareness to the physical sensation of the breath. Notice the rising and falling of the abdomen and chest and the feeling of the breath as it travels in and out the nostrils or mouth (perhaps observing that the inhale is slightly cooler than the exhale). Each time the mind becomes distracted by thoughts, feelings, sounds, or physical sensations, don't worry, as this is completely normal. Simply acknowledge that distraction and continue to draw the focus back to the breath.", "https://unsplash.com/photos/efe3IfUqnfY", "https://www.mindbodygreen.com/articles/meditation-for-sadness", "Let’s Dance David Bowie: https://open.spotify.com/track/2tgw0vmJDgckHwW2PdYTGo?si=80bd03eb43244f3b", "Sad", "'There are moments when I wish I could roll back the clock and take all the sadness away, but I have the feeling that if I did, the joy would be gone as well' Nicholas Sparks" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "OA9396", "Practicing progressive muscle relaxation: Consult with your doctor first if you have a history of muscle spasms, back problems, or other serious injuries that may be aggravated by tensing muscles. Start at your feet and work your way up to your face, trying to only tense those muscles intended. 1. Loosen clothing, take off your shoes, and get comfortable. 2. Take a few minutes to breathe in and out in slow, deep breaths. 3. When you’re ready, shift your attention to your right foot. Take a moment to focus on the way it feels. 4. Slowly tense the muscles in your right foot, squeezing as tightly as you can. Hold for a count of 10. 5. Relax your foot. Focus on the tension flowing away and how your foot feels as it becomes limp and loose. 6. Stay in this relaxed state for a moment, breathing deeply and slowly. 7. Shift your attention to your left foot. Follow the same sequence of muscle tension and release. 8. Move slowly up through your body, contracting and relaxing the different muscle groups. 9. It may take some practice at first, but try not to tense muscles other than those intended.", "https://unsplash.com/photos/ruQHpukrN7c", "https://www.helpguide.org/articles/stress/relaxation-techniques-for-stress-relief.htm", "Lila Rodriguez Jr.: https://open.spotify.com/track/7ckJgqAp6jAUSJ9Av2t9LY?si=9a48827d174f4587", "Nervous", "'Courage doesn’t always roar. Sometimes courage is the quiet voice at the end of the day saying, I will try again tomorrow.' Mary Anne Radmacher" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 10,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "Rose", "1. Approach your inner-critic. Your inner-critic is that persistent voice or thought in your head that takes every possible opportunity to make you feel worse about even the smallest perceived faults, failures, and imperfections. Spend some time really listening to your inner-critic. Sometimes we are so intent on shutting out negative inner voices that we fail to hear exactly what's being said. 2. Get to know your inner-critic better. Try to listen to your inner-critic across different situations, and take notice of the themes and similarities that run through these critiques. Putting a face, character, or specific voice to your inner-critic will help you listen more deeply and get to the heart of the messages about yourself that your inner-critic is sending. 3. Befriend your inner-critic. Friendship does not mean that you accept what your inner-critic says, verbatim. A friend is someone who you feel comfortable challenging and will love you despite any transformations you may undergo. Accept the presence of your inner-critic and be willing to lovingly accept and challenge what it has to say. Your inner-critic may be expressing an important need that is going unmet, albeit in a distorted manner.", "https://unsplash.com/photos/-SbQgia5ggg", "https://www.wikihow.com/Feel-More-Secure", "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b?si=9abb1d91e13e45e7", "Insecure", "Don't let fear or insecurity stop you from trying new things. Believe in yourself. Do what you love. And most importantly, be kind to others, even if you don't like them. - Stacy London" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName" },
                values: new object[] { "Orange", "Everyday is a half day if you just fucking leave.", "Lets see if this loads", "https://www.sadanduseless.com/legs-or-sausages-gallery/", "cheerful", "Anxiety" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName" },
                values: new object[] { "", "", "../", "", "", "Guilt" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 3,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName" },
                values: new object[] { "", "", "", "", "", "Depression" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 4,
                column: "ResourceExercise",
                value: "5, 4, 3, 2, 1 Mindfulness exercise");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 5,
                columns: new[] { "ResourceExercise", "ResourceName" },
                values: new object[] { "Box Breathing", "Fear" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 6,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "", "", "", "", "Depression", "" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 7,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "", "", "", "", "Depression", "" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 8,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "", "", "", "", "", "Depression", "" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 9,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "", "", "", "", "", "Depression", "" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 10,
                columns: new[] { "ResourceColor", "ResourceExercise", "ResourceImage", "ResourceLink", "ResourceMusic", "ResourceName", "ResourceQuote" },
                values: new object[] { "", "", "", "", "", "Depression", "" });
        }
    }
}
