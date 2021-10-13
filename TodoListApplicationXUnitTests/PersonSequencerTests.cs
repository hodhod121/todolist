﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApplication.Data;
using Xunit;

namespace TodoListApplicationXUnitTests
{
    public class PersonSequencerTests
    {
        public PersonSequencer personSequencer;
        public PersonSequencerTests()
        {
            personSequencer = new PersonSequencer();
        }
        [Fact]
        public void People_ReturnsTrue()
        {
            Assert.True(PersonSequencer.personId == 0);
            Assert.True(PersonSequencer.reset() == 0);
            Assert.True(personSequencer.nextPersonId() == 1);
            Assert.False(personSequencer.nextPersonId() == 1);

        }
    }
}