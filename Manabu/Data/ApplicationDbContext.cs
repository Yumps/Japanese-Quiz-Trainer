using System;
using System.Collections.Generic;
using System.Text;
using Manabu.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Manabu.Models.ViewModels;

namespace Manabu.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<AnswerKey> AnswerKeys { get; set; }
        public DbSet<FlashCard> FlashCards { get; set; }
        public DbSet<QuizQuestions> QuizQuestions { get; set; }
        public DbSet<UserQuestionAnswer> UserQuestionAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Quiz>().HasData(
                new Quiz()
                {
                    Id = 1,
                    Name = "Quiz 1"
                },
                new Quiz()
                {
                    Id = 2,
                    Name = "Quiz 2"
                },
                new Quiz()
                {
                    Id = 3,
                    Name = "Quiz 3"
                },
                new Quiz()
                {
                    Id = 4,
                    Name = "Quiz 4"
                },
                new Quiz()
                {
                    Id = 5,
                    Name = "Quiz 5"
                },
                new Quiz()
                {
                    Id = 6,
                    Name = "Quiz 6"
                },
                new Quiz()
                {
                    Id = 7,
                    Name = "Quiz 7"
                }
            );

            modelBuilder.Entity<Question>().HasData(
                new Question()
                {
                    Id = 1,
                    Name = "や"
                },

                new Question()
                {
                    Id = 2,
                    Name = "あ"
                },

                new Question()
                {
                    Id = 3,
                    Name = "い"
                },

                new Question()
                {
                    Id = 4,
                    Name = "う"
                },
               
                new Question()
                {
                    Id = 5,
                    Name = "え"
                },

                new Question()
                {
                    Id = 6,
                    Name = "お"
                },

                new Question()
                {
                    Id = 7,
                    Name = "か"
                },

                new Question()
                {
                    Id = 8,
                    Name = "き"
                },

                new Question()
                {
                    Id = 9,
                    Name = "く"
                },

                new Question()
                {
                    Id = 10,
                    Name = "け"
                },

                new Question()
                {
                    Id = 11,
                    Name = "こ"
                },

                new Question()
                {
                    Id = 12,
                    Name = "が"
                },

                new Question()
                {
                    Id = 13,
                    Name = "ぎ"
                },

                new Question()
                {
                    Id = 14,
                    Name = "ぐ"
                },

                new Question()
                {
                    Id = 15,
                    Name = "げ"
                },

                new Question()
                {
                    Id = 16,
                    Name = "ご"
                },

                new Question()
                {
                    Id = 17,
                    Name = "さ"
                },

                new Question()
                {
                    Id = 18,
                    Name = "し"
                },

                new Question()
                {
                    Id = 19,
                    Name = "す"
                },

                new Question()
                {
                    Id = 20,
                    Name = "せ"
                },

                new Question()
                {
                    Id = 21,
                    Name = "そ"
                },

                new Question()
                {
                    Id = 22,
                    Name = "ざ"
                },

                new Question()
                {
                    Id = 23,
                    Name = "じ"
                },

                new Question()
                {
                    Id = 24,
                    Name = "ず"
                },

                new Question()
                {
                    Id = 25,
                    Name = "ぜ"
                },

                new Question()
                {
                    Id = 26,
                    Name = "ぞ"
                },

                new Question()
                {
                    Id = 27,
                    Name = "た"
                },

                new Question()
                {
                    Id = 28,
                    Name = "ち"
                },

                new Question()
                {
                    Id = 29,
                    Name = "つ"
                },

                new Question()
                {
                    Id = 30,
                    Name = "て"
                },

                new Question()
                {
                    Id = 31,
                    Name = "と"
                },

                new Question()
                {
                    Id = 32,
                    Name = "だ"
                },

                new Question()
                {
                    Id = 33,
                    Name = "ぢ"
                },

                new Question()
                {
                    Id = 34,
                    Name = "づ"
                },

                new Question()
                {
                    Id = 35,
                    Name = "で"
                },

                new Question()
                {
                    Id = 36,
                    Name = "ど"
                },

                new Question()
                {
                    Id = 37,
                    Name = "な"
                },

                new Question()
                {
                    Id = 38,
                    Name = "に"
                },

                new Question()
                {
                    Id = 39,
                    Name = "ぬ"
                },

                new Question()
                {
                    Id = 40,
                    Name = "ね"
                },

                new Question()
                {
                    Id = 41,
                    Name = "の"
                },

                new Question()
                {
                    Id = 42,
                    Name = "は"
                },

                new Question()
                {
                    Id = 43,
                    Name = "ひ"
                },

                new Question()
                {
                    Id = 44,
                    Name = "ふ"
                },

                new Question()
                {
                    Id = 45,
                    Name = "へ"
                },

                new Question()
                {
                    Id = 46,
                    Name = "ほ"
                },

                new Question()
                {
                    Id = 47,
                    Name = "ば"
                },

                new Question()
                {
                    Id = 48,
                    Name = "び"
                },

                new Question()
                {
                    Id = 49,
                    Name = "ぶ"
                },

                new Question()
                {
                    Id = 50,
                    Name = "べ"
                },

                new Question()
                {
                    Id = 51,
                    Name = "ぼ"
                },

                new Question()
                {
                    Id = 52,
                    Name = "ぱ"
                },

                new Question()
                {
                    Id = 53,
                    Name = "ぴ"
                },

                new Question()
                {
                    Id = 54,
                    Name = "ぷ"
                },

                new Question()
                {
                    Id = 55,
                    Name = "ぺ"
                },

                new Question()
                {
                    Id = 56,
                    Name = "ぽ"
                },

                new Question()
                {
                    Id = 57,
                    Name = "ま"
                },

                new Question()
                {
                    Id = 58,
                    Name = "み"
                },

                new Question()
                {
                    Id = 59,
                    Name = "む"
                },

                new Question()
                {
                    Id = 60,
                    Name = "め"
                },

                new Question()
                {
                    Id = 61,
                    Name = "も"
                },

                new Question()
                {
                    Id = 62,
                    Name = "ゆ"
                },

                new Question()
                {
                    Id = 63,
                    Name = "よ"
                },

                new Question()
                {
                    Id = 64,
                    Name = "ら"
                },

                new Question()
                {
                    Id = 65,
                    Name = "り"
                },

                new Question()
                {
                    Id = 66,
                    Name = "る"
                },

                new Question()
                {
                    Id = 67,
                    Name = "れ"
                },

                new Question()
                {
                    Id = 68,
                    Name = "ろ"
                },

                new Question()
                {
                    Id = 69,
                    Name = "わ"
                },

                new Question()
                {
                    Id = 70,
                    Name = "を"
                },

                new Question()
                {
                    Id = 71,
                    Name = "ん"
                }
            );

            modelBuilder.Entity<AnswerKey>().HasData(
                new AnswerKey()
                {
                    Id = 1,
                    Name = "ya",
                    QuestionId = 1
                },

                new AnswerKey()
                {
                    Id = 2,
                    Name = "a",
                    QuestionId = 2
                },

                new AnswerKey()
                {
                    Id = 3,
                    Name = "i",
                    QuestionId = 3
                },

                new AnswerKey()
                {
                    Id = 4,
                    Name = "u",
                    QuestionId = 4
                },

                new AnswerKey()
                {
                    Id = 5,
                    Name = "e",
                    QuestionId = 5
                },

                new AnswerKey()
                {
                    Id = 6,
                    Name = "o",
                    QuestionId = 6
                },

                new AnswerKey()
                {
                    Id = 7,
                    Name = "ka",
                    QuestionId = 7
                },

                new AnswerKey()
                {
                    Id = 8,
                    Name = "ki",
                    QuestionId = 8
                },

                new AnswerKey()
                {
                    Id = 9,
                    Name = "ku",
                    QuestionId = 9
                },

                new AnswerKey()
                {
                    Id = 10,
                    Name = "ke",
                    QuestionId = 10
                },

                new AnswerKey()
                {
                    Id = 11,
                    Name = "ko",
                    QuestionId = 11
                },

                new AnswerKey()
                {
                    Id = 12,
                    Name = "ga",
                    QuestionId = 12
                },

                new AnswerKey()
                {
                    Id = 13,
                    Name = "gi",
                    QuestionId = 13
                },

                new AnswerKey()
                {
                    Id = 14,
                    Name = "gu",
                    QuestionId = 14
                },

                new AnswerKey()
                {
                    Id = 15,
                    Name = "ge",
                    QuestionId = 15
                },

                new AnswerKey()
                {
                    Id = 16,
                    Name = "go",
                    QuestionId = 16
                },

                new AnswerKey()
                {
                    Id = 17,
                    Name = "sa",
                    QuestionId = 17
                },

                new AnswerKey()
                {
                    Id = 18,
                    Name = "shi",
                    QuestionId = 18
                },

                new AnswerKey()
                {
                    Id = 19,
                    Name = "su",
                    QuestionId = 19
                },

                new AnswerKey()
                {
                    Id = 20,
                    Name = "se",
                    QuestionId = 20
                },

                new AnswerKey()
                {
                    Id = 21,
                    Name = "so",
                    QuestionId = 21
                },

                new AnswerKey()
                {
                    Id = 22,
                    Name = "za",
                    QuestionId = 22
                },

                new AnswerKey()
                {
                    Id = 23,
                    Name = "ji",
                    QuestionId = 23
                },

                new AnswerKey()
                {
                    Id = 24,
                    Name = "zu",
                    QuestionId = 24
                },

                new AnswerKey()
                {
                    Id = 25,
                    Name = "ze",
                    QuestionId = 25
                },

                new AnswerKey()
                {
                    Id = 26,
                    Name = "zo",
                    QuestionId = 26
                },

                new AnswerKey()
                {
                    Id = 27,
                    Name = "ta",
                    QuestionId = 27
                },

                new AnswerKey()
                {
                    Id = 28,
                    Name = "chi",
                    QuestionId = 28
                },

                new AnswerKey()
                {
                    Id = 29,
                    Name = "tsu",
                    QuestionId = 29
                },

                new AnswerKey()
                {
                    Id = 30,
                    Name = "te",
                    QuestionId = 30
                },

                new AnswerKey()
                {
                    Id = 31,
                    Name = "to",
                    QuestionId = 31
                },

                new AnswerKey()
                {
                    Id = 32,
                    Name = "da",
                    QuestionId = 32
                },

                new AnswerKey()
                {
                    Id = 33,
                    Name = "dji",
                    QuestionId = 33
                },

                new AnswerKey()
                {
                    Id = 34,
                    Name = "dzu",
                    QuestionId = 34
                },

                new AnswerKey()
                {
                    Id = 35,
                    Name = "de",
                    QuestionId = 35
                },

                new AnswerKey()
                {
                    Id = 36,
                    Name = "do",
                    QuestionId = 36
                },

                new AnswerKey()
                {
                    Id = 37,
                    Name = "na",
                    QuestionId = 37
                },

                new AnswerKey()
                {
                    Id = 38,
                    Name = "ni",
                    QuestionId = 38
                },

                new AnswerKey()
                {
                    Id = 39,
                    Name = "nu",
                    QuestionId = 39
                },

                new AnswerKey()
                {
                    Id = 40,
                    Name = "ne",
                    QuestionId = 40
                },

                new AnswerKey()
                {
                    Id = 41,
                    Name = "no",
                    QuestionId = 41
                },

                new AnswerKey()
                {
                    Id = 42,
                    Name = "ha",
                    QuestionId = 42
                },

                new AnswerKey()
                {
                    Id = 43,
                    Name = "hi",
                    QuestionId = 43
                },

                new AnswerKey()
                {
                    Id = 44,
                    Name = "fu",
                    QuestionId = 44
                },

                new AnswerKey()
                {
                    Id = 45,
                    Name = "he",
                    QuestionId = 45
                },

                new AnswerKey()
                {
                    Id = 46,
                    Name = "ho",
                    QuestionId = 46
                },

                new AnswerKey()
                {
                    Id = 47,
                    Name = "ba",
                    QuestionId = 47
                },

                new AnswerKey()
                {
                    Id = 48,
                    Name = "bi",
                    QuestionId = 48
                },

                new AnswerKey()
                {
                    Id = 49,
                    Name = "bu",
                    QuestionId = 49
                },

                new AnswerKey()
                {
                    Id = 50,
                    Name = "be",
                    QuestionId =50
                },

                new AnswerKey()
                {
                    Id = 51,
                    Name = "bo",
                    QuestionId = 51
                },

                new AnswerKey()
                {
                    Id = 52,
                    Name = "pa",
                    QuestionId = 52
                },

                new AnswerKey()
                {
                    Id = 53,
                    Name = "pi",
                    QuestionId = 53
                },

                new AnswerKey()
                {
                    Id = 54,
                    Name = "pu",
                    QuestionId = 54
                },

                new AnswerKey()
                {
                    Id = 55,
                    Name = "pe",
                    QuestionId = 55
                },

                new AnswerKey()
                {
                    Id = 56,
                    Name = "po",
                    QuestionId = 56
                },

                new AnswerKey()
                {
                    Id = 57,
                    Name = "ma",
                    QuestionId = 57
                },

                new AnswerKey()
                {
                    Id = 58,
                    Name = "mi",
                    QuestionId = 58
                },

                new AnswerKey()
                {
                    Id = 59,
                    Name = "mu",
                    QuestionId = 59
                },

                new AnswerKey()
                {
                    Id = 60,
                    Name = "me",
                    QuestionId = 60
                },

                new AnswerKey()
                {
                    Id = 61,
                    Name = "mo",
                    QuestionId = 61
                },

                new AnswerKey()
                {
                    Id = 62,
                    Name = "yu",
                    QuestionId = 62
                },

                new AnswerKey()
                {
                    Id = 63,
                    Name = "yo",
                    QuestionId = 63
                },

                new AnswerKey()
                {
                    Id = 64,
                    Name = "ra",
                    QuestionId = 64
                },

                new AnswerKey()
                {
                    Id = 65,
                    Name = "ri",
                    QuestionId = 65
                },

                new AnswerKey()
                {
                    Id = 66,
                    Name = "ru",
                    QuestionId = 66
                },

                new AnswerKey()
                {
                    Id = 67,
                    Name = "re",
                    QuestionId = 67
                },

                new AnswerKey()
                {
                    Id = 68,
                    Name = "ro",
                    QuestionId = 68
                },

                new AnswerKey()
                {
                    Id = 69,
                    Name = "wa",
                    QuestionId = 69
                },

                new AnswerKey()
                {
                    Id = 70,
                    Name = "wo",
                    QuestionId = 70
                },

                new AnswerKey()
                {
                    Id = 71,
                    Name = "n",
                    QuestionId = 71
                }
            );

            modelBuilder.Entity<FlashCard>().HasData(
                new FlashCard()
                {
                    Id = 1,
                    Question = "や",
                    Answer = "ya",
                    UserId = user.Id
                }
            );

            modelBuilder.Entity<QuizQuestions>().HasData(
                new QuizQuestions()
                {
                    Id = 1,
                    QuizId = 1,
                    QuestionId = 1
                },
                new QuizQuestions()
                {
                    Id = 2,
                    QuizId = 1,
                    QuestionId = 2
                },
                new QuizQuestions()
                {
                    Id = 3,
                    QuizId = 1,
                    QuestionId = 3
                },
                new QuizQuestions()
                {
                    Id = 4,
                    QuizId = 1,
                    QuestionId = 4
                },
                new QuizQuestions()
                {
                    Id = 5,
                    QuizId = 1,
                    QuestionId = 5
                },
                new QuizQuestions()
                {
                    Id = 6,
                    QuizId = 1,
                    QuestionId = 6
                },
                new QuizQuestions()
                {
                    Id = 7,
                    QuizId = 1,
                    QuestionId = 7
                },
                new QuizQuestions()
                {
                    Id = 8,
                    QuizId = 1,
                    QuestionId = 8
                },
                new QuizQuestions()
                {
                    Id = 9,
                    QuizId = 1,
                    QuestionId = 9
                },
                new QuizQuestions()
                {
                    Id = 10,
                    QuizId = 1,
                    QuestionId = 10
                },
                new QuizQuestions()
                {
                    Id = 11,
                    QuizId = 2,
                    QuestionId = 13 
                },
                new QuizQuestions()
                {
                    Id = 12,
                    QuizId = 2,
                    QuestionId = 14
                },
                new QuizQuestions()
                {
                    Id = 13,
                    QuizId = 2,
                    QuestionId = 16
                },
                new QuizQuestions()
                {
                    Id = 14,
                    QuizId = 2,
                    QuestionId = 20
                },
                new QuizQuestions()
                {
                    Id = 15,
                    QuizId = 2,
                    QuestionId = 34
                },
                new QuizQuestions()
                {
                    Id = 16,
                    QuizId = 2,
                    QuestionId = 35
                },
                new QuizQuestions()
                {
                    Id = 17,
                    QuizId = 2,
                    QuestionId = 55
                },
                new QuizQuestions()
                {
                    Id = 18,
                    QuizId = 2,
                    QuestionId = 56
                },
                new QuizQuestions()
                {
                    Id = 19,
                    QuizId = 2,
                    QuestionId = 63
                },
                new QuizQuestions()
                {
                    Id = 20,
                    QuizId = 2,
                    QuestionId = 68
                },
                new QuizQuestions()
                {
                    Id = 21,
                    QuizId = 3,
                    QuestionId = 11
                },
                new QuizQuestions()
                {
                    Id = 22,
                    QuizId = 3,
                    QuestionId = 29
                },
                new QuizQuestions()
                {
                    Id = 23,
                    QuizId = 3,
                    QuestionId = 31
                },
                new QuizQuestions()
                {
                    Id = 24,
                    QuizId = 3,
                    QuestionId = 36
                },
                new QuizQuestions()
                {
                    Id = 25,
                    QuizId = 3,
                    QuestionId = 37
                },
                new QuizQuestions()
                {
                    Id = 26,
                    QuizId = 3,
                    QuestionId = 44
                },
                new QuizQuestions()
                {
                    Id = 27,
                    QuizId = 3,
                    QuestionId = 22
                },
                new QuizQuestions()
                {
                    Id = 28,
                    QuizId = 3,
                    QuestionId = 28
                },
                new QuizQuestions()
                {
                    Id = 29,
                    QuizId = 3,
                    QuestionId = 30
                },
                new QuizQuestions()
                {
                    Id = 30,
                    QuizId = 3,
                    QuestionId = 33
                },
                new QuizQuestions()
                {
                    Id = 31,
                    QuizId = 4,
                    QuestionId = 39
                },
                new QuizQuestions()
                {
                    Id = 32,
                    QuizId = 4,
                    QuestionId = 48
                },
                new QuizQuestions()
                {
                    Id = 33,
                    QuizId = 4,
                    QuestionId = 71
                },
                new QuizQuestions()
                {
                    Id = 34,
                    QuizId = 4,
                    QuestionId = 26
                },
                new QuizQuestions()
                {
                    Id = 35,
                    QuizId = 4,
                    QuestionId = 52
                },
                new QuizQuestions()
                {
                    Id = 36,
                    QuizId = 4,
                    QuestionId = 58
                },
                new QuizQuestions()
                {
                    Id = 37,
                    QuizId = 4,
                    QuestionId = 65
                },
                new QuizQuestions()
                {
                    Id = 38,
                    QuizId = 4,
                    QuestionId = 70
                },
                new QuizQuestions()
                {
                    Id = 39,
                    QuizId = 4,
                    QuestionId = 17
                },
                new QuizQuestions()
                {
                    Id = 40,
                    QuizId = 4,
                    QuestionId = 19
                },
                new QuizQuestions()
                {
                    Id = 41,
                    QuizId = 5,
                    QuestionId = 38
                },
                new QuizQuestions()
                {
                    Id = 42,
                    QuizId = 5,
                    QuestionId = 51
                },
                new QuizQuestions()
                {
                    Id = 43,
                    QuizId = 5,
                    QuestionId = 54
                },
                new QuizQuestions()
                {
                    Id = 44,
                    QuizId = 5,
                    QuestionId = 67
                },
                new QuizQuestions()
                {
                    Id = 45,
                    QuizId = 5,
                    QuestionId = 69
                },
                new QuizQuestions()
                {
                    Id = 46,
                    QuizId = 5,
                    QuestionId = 50
                },
                new QuizQuestions()
                {
                    Id = 47,
                    QuizId = 5,
                    QuestionId = 61
                },
                new QuizQuestions()
                {
                    Id = 48,
                    QuizId = 5,
                    QuestionId = 64
                },
                new QuizQuestions()
                {
                    Id = 49,
                    QuizId = 5,
                    QuestionId = 12
                },
                new QuizQuestions()
                {
                    Id = 50,
                    QuizId = 5,
                    QuestionId = 43
                },
                new QuizQuestions()
                {
                    Id = 51,
                    QuizId = 6,
                    QuestionId = 57
                },
                new QuizQuestions()
                {
                    Id = 52,
                    QuizId = 6,
                    QuestionId = 59
                },
                new QuizQuestions()
                {
                    Id = 53,
                    QuizId = 6,
                    QuestionId = 32
                },
                new QuizQuestions()
                {
                    Id = 54,
                    QuizId = 6,
                    QuestionId = 21
                },
                new QuizQuestions()
                {
                    Id = 55,
                    QuizId = 6,
                    QuestionId = 60
                },
                new QuizQuestions()
                {
                    Id = 56,
                    QuizId = 6,
                    QuestionId = 40
                },
                new QuizQuestions()
                {
                    Id = 57,
                    QuizId = 6,
                    QuestionId = 25
                },
                new QuizQuestions()
                {
                    Id = 58,
                    QuizId = 6,
                    QuestionId = 23
                },
                new QuizQuestions()
                {
                    Id = 59,
                    QuizId = 6,
                    QuestionId = 47
                },
                new QuizQuestions()
                {
                    Id = 60,
                    QuizId = 6,
                    QuestionId = 53
                },
                new QuizQuestions()
                {
                    Id = 61,
                    QuizId = 7,
                    QuestionId = 24
                },
                new QuizQuestions()
                {
                    Id = 62,
                    QuizId = 7,
                    QuestionId = 15
                },
                new QuizQuestions()
                {
                    Id = 63,
                    QuizId = 7,
                    QuestionId = 41
                },
                new QuizQuestions()
                {
                    Id = 64,
                    QuizId = 7,
                    QuestionId = 66
                },
                new QuizQuestions()
                {
                    Id = 65,
                    QuizId = 7,
                    QuestionId = 62
                },
                new QuizQuestions()
                {
                    Id = 66,
                    QuizId = 7,
                    QuestionId = 46
                },
                new QuizQuestions()
                {
                    Id = 67,
                    QuizId = 7,
                    QuestionId = 42
                },
                new QuizQuestions()
                {
                    Id = 68,
                    QuizId = 7,
                    QuestionId = 45
                },
                new QuizQuestions()
                {
                    Id = 69,
                    QuizId = 7,
                    QuestionId = 18
                },
                new QuizQuestions()
                {
                    Id = 70,
                    QuizId = 7,
                    QuestionId = 49
                },
                new QuizQuestions()
                {
                    Id = 71,
                    QuizId = 7,
                    QuestionId = 27
                }
            );
        }
    }
}
