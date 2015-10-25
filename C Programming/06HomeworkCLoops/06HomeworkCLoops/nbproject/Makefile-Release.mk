#
# Generated Makefile - do not edit!
#
# Edit the Makefile in the project folder instead (../Makefile). Each target
# has a -pre and a -post target defined where you can add customized code.
#
# This makefile implements configuration specific macros and targets.


# Environment
MKDIR=mkdir
CP=cp
GREP=grep
NM=nm
CCADMIN=CCadmin
RANLIB=ranlib
CC=gcc
CCC=g++
CXX=g++
FC=gfortran
AS=as

# Macros
CND_PLATFORM=GNU-Linux-x86
CND_DLIB_EXT=so
CND_CONF=Release
CND_DISTDIR=dist
CND_BUILDDIR=build

# Include project Makefile
include Makefile

# Object Directory
OBJECTDIR=${CND_BUILDDIR}/${CND_CONF}/${CND_PLATFORM}

# Object Files
OBJECTFILES= \
	${OBJECTDIR}/01NumbersFrom1ToN.o \
	${OBJECTDIR}/02NumbersNotDivisibleBy3And7.o \
	${OBJECTDIR}/03Min,Max,SumAndAverage.o \
	${OBJECTDIR}/04PrintADeckOf52Cards.o \
	${OBJECTDIR}/05CalculateN!DividedByXTimesN.o \
	${OBJECTDIR}/06CalculateN!DividedByK!.o \
	${OBJECTDIR}/07CalculateN!K!Combinations.o \
	${OBJECTDIR}/08CatalanNumbers.o \
	${OBJECTDIR}/09MatrixOfNumbers.o \
	${OBJECTDIR}/10OddAndEvenProduct.o \
	${OBJECTDIR}/11RandomNumbersInGivenRange.o \
	${OBJECTDIR}/12RandomizeNumbers1ToN.o \
	${OBJECTDIR}/13BinaryToDecimal.o \
	${OBJECTDIR}/14DecimalToBinary.o \
	${OBJECTDIR}/15HexadecimalToDecimal.o \
	${OBJECTDIR}/16DecimalToHexadecimal.o \
	${OBJECTDIR}/17CalculateGCD.o \
	${OBJECTDIR}/18TrailingZeroes.o \
	${OBJECTDIR}/19SpiralMatrix.o


# C Compiler Flags
CFLAGS=

# CC Compiler Flags
CCFLAGS=
CXXFLAGS=

# Fortran Compiler Flags
FFLAGS=

# Assembler Flags
ASFLAGS=

# Link Libraries and Options
LDLIBSOPTIONS=

# Build Targets
.build-conf: ${BUILD_SUBPROJECTS}
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/06homeworkcloops

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/06homeworkcloops: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/06homeworkcloops ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/01NumbersFrom1ToN.o: 01NumbersFrom1ToN.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/01NumbersFrom1ToN.o 01NumbersFrom1ToN.c

${OBJECTDIR}/02NumbersNotDivisibleBy3And7.o: 02NumbersNotDivisibleBy3And7.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/02NumbersNotDivisibleBy3And7.o 02NumbersNotDivisibleBy3And7.c

${OBJECTDIR}/03Min,Max,SumAndAverage.o: 03Min,Max,SumAndAverage.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03Min,Max,SumAndAverage.o 03Min,Max,SumAndAverage.c

${OBJECTDIR}/04PrintADeckOf52Cards.o: 04PrintADeckOf52Cards.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04PrintADeckOf52Cards.o 04PrintADeckOf52Cards.c

${OBJECTDIR}/05CalculateN!DividedByXTimesN.o: 05CalculateN!DividedByXTimesN.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05CalculateN!DividedByXTimesN.o 05CalculateN!DividedByXTimesN.c

${OBJECTDIR}/06CalculateN!DividedByK!.o: 06CalculateN!DividedByK!.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06CalculateN!DividedByK!.o 06CalculateN!DividedByK!.c

${OBJECTDIR}/07CalculateN!K!Combinations.o: 07CalculateN!K!Combinations.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07CalculateN!K!Combinations.o 07CalculateN!K!Combinations.c

${OBJECTDIR}/08CatalanNumbers.o: 08CatalanNumbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/08CatalanNumbers.o 08CatalanNumbers.c

${OBJECTDIR}/09MatrixOfNumbers.o: 09MatrixOfNumbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/09MatrixOfNumbers.o 09MatrixOfNumbers.c

${OBJECTDIR}/10OddAndEvenProduct.o: 10OddAndEvenProduct.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/10OddAndEvenProduct.o 10OddAndEvenProduct.c

${OBJECTDIR}/11RandomNumbersInGivenRange.o: 11RandomNumbersInGivenRange.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/11RandomNumbersInGivenRange.o 11RandomNumbersInGivenRange.c

${OBJECTDIR}/12RandomizeNumbers1ToN.o: 12RandomizeNumbers1ToN.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/12RandomizeNumbers1ToN.o 12RandomizeNumbers1ToN.c

${OBJECTDIR}/13BinaryToDecimal.o: 13BinaryToDecimal.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/13BinaryToDecimal.o 13BinaryToDecimal.c

${OBJECTDIR}/14DecimalToBinary.o: 14DecimalToBinary.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/14DecimalToBinary.o 14DecimalToBinary.c

${OBJECTDIR}/15HexadecimalToDecimal.o: 15HexadecimalToDecimal.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/15HexadecimalToDecimal.o 15HexadecimalToDecimal.c

${OBJECTDIR}/16DecimalToHexadecimal.o: 16DecimalToHexadecimal.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/16DecimalToHexadecimal.o 16DecimalToHexadecimal.c

${OBJECTDIR}/17CalculateGCD.o: 17CalculateGCD.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/17CalculateGCD.o 17CalculateGCD.c

${OBJECTDIR}/18TrailingZeroes.o: 18TrailingZeroes.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/18TrailingZeroes.o 18TrailingZeroes.c

${OBJECTDIR}/19SpiralMatrix.o: 19SpiralMatrix.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/19SpiralMatrix.o 19SpiralMatrix.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/06homeworkcloops

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
