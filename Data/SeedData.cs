using Microsoft.EntityFrameworkCore;
using DuneLibrary.Models;

namespace DuneLibrary.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new DuneLibraryContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<DuneLibraryContext>>());

        if (context == null || context.Passage == null)
        {
            throw new NullReferenceException(
                "Null BlazorWebAppMoviesContext or Movie DbSet");
        }

        if (context.Passage.Any())
        {
            return;
        }

        context.Passage.AddRange(
            new Passage
            {
                Passages = "A beginning is the time for taking the most delicate care that the balances are correct. This every sister of the Bene Gesserit knows. To begin your study of the life of Muad'Dib, then, take care that you first place him in his time: born in the 57th year of the Padishah Emperor, Shaddam IV. And take the most special care that you locate Muad'Dib in his place: the planet Arrakis. Do not be deceived by the fact that he was born on Caladan and lived his first fifteen years there. Arrakis, the planet known as Dune, is forever his place.",
                Book = "Dune",
                ChapterNum = 1,
                Author = "The Princess Irulan",
                Series = "Manual of Muad'Dib",
                Organization = "N/A",
                WordCount = 101,
                AverageRating = 1,
            },
            new Passage
            {
                Passages = "Such a rich store of myths enfolds Paul Muad'Dib, the Mentat Emperor, and his sister, Alia, it is difficult to see the real persons behind these veils. But there were, after all, a man born Paul Atreides and a woman born Alia. Their flesh was subject to space and time. And even though their oracular powers placed them beyond the usual limits of time and space, they came from human stock. They experienced real events which left real traces upon a real universe. To understand them, it must be seen that their catastrophe was the catastrophe of all mankind. This work is dedicated, then, not to Muad'Dib or his sister, but to their heirs-to all of us.",
                Book = "Dune Messiah",
                ChapterNum = 1,
                Author = "N/A",
                Series = "Dedication in the Muad'Dib concordance as copied from the tabla",
                Organization = "Memorium of the Mahdi Spirit Cult",
                WordCount = 117,
                AverageRating = 1,
            },
            new Passage
            {
                Passages = "Muad'Dib's teachings have become the playground of scholastics, of the superstitious and the corrupt. He taught a balanced way of life, a philosophy with which a human can meet problems arising from an ever-changing universe. He said humankind is still evolving, in a process which will never end. He said this evolution moves on changing principles which are known only to eternity. How can corrupted reasoning play with such an essence?",
                Book = "Children of Dune",
                ChapterNum = 1,
                Author = "Duncan Idaho",
                Series = "Words of the Mentat Duncan Idaho",
                Organization = "N/A",
                WordCount = 71,
                AverageRating = 1,
            },
            new Passage
            {
                Passages = "This morning I was born in a yurt at the edge of a horse-plain in a land of a planet which no longer exists. Tomorrow I will be born someone else in another place. I have not yet chosen. This morning, though-ahhh, this life! When my eyes had learned to focus I looked out at sunshine on trampled grass and I saw vigorous people going about the sweet activities of their lives. Where ... oh where has all of that vigor gone?",
                Book = "God Emperor of Dune",
                ChapterNum = 1,
                Author = "God Emperor Leto II",
                Series = "The Stolen Journals",
                Organization = "",
                WordCount = 81,
                AverageRating = 1,
            },
            new Passage
            {
                Passages = "Most discipline is hidden discipline, designed not to liberate but to limit. Do not ask Why? Be cautious with How? Why? leads inexorably to paradox. How? traps you in a universe of cause and effect. Both deny the infinite.",
                Book = "Heretics of Dune",
                ChapterNum = 1,
                Author = "N/A",
                Series = "The Apocrypha of Arrakis",
                Organization = "N/A",
                WordCount = 39,
                AverageRating = 1,
            },
            new Passage
            {
                Passages = "Those who would repeat the past must control the teaching of history.",
                Book = "Chapterhouse: Dune",
                ChapterNum = 1,
                Author = "N/A",
                Series = "Bene Gesserit Coda",
                Organization = "Bene Gesserit",
                WordCount = 12,
                AverageRating = 1,
            });

        context.SaveChanges();
    }
}