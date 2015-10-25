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
	${OBJECTDIR}/01ExchangeIfGreater.o \
	${OBJECTDIR}/02BonusScore.o \
	${OBJECTDIR}/03CheckForAPlayCard.o \
	${OBJECTDIR}/04MultiplicationSign.o \
	${OBJECTDIR}/05TheBiggestOf3Numbers.o \
	${OBJECTDIR}/06BiggesOf5Numbers.o \
	${OBJECTDIR}/07Sort3NumbersWithNestedIfs.o \
	${OBJECTDIR}/08DigitAsWord.o \
	${OBJECTDIR}/09PlayWithIntDoubleAndString.o \
	${OBJECTDIR}/10BeerTime.o \
	${OBJECTDIR}/11NumberAsWords.o \
	${OBJECTDIR}/12ZeroSubset.o


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
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/05homeworkconditionalstatements

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/05homeworkconditionalstatements: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/05homeworkconditionalstatements ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/01ExchangeIfGreater.o: 01ExchangeIfGreater.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/01ExchangeIfGreater.o 01ExchangeIfGreater.c

${OBJECTDIR}/02BonusScore.o: 02BonusScore.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/02BonusScore.o 02BonusScore.c

${OBJECTDIR}/03CheckForAPlayCard.o: 03CheckForAPlayCard.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03CheckForAPlayCard.o 03CheckForAPlayCard.c

${OBJECTDIR}/04MultiplicationSign.o: 04MultiplicationSign.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04MultiplicationSign.o 04MultiplicationSign.c

${OBJECTDIR}/05TheBiggestOf3Numbers.o: 05TheBiggestOf3Numbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05TheBiggestOf3Numbers.o 05TheBiggestOf3Numbers.c

${OBJECTDIR}/06BiggesOf5Numbers.o: 06BiggesOf5Numbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06BiggesOf5Numbers.o 06BiggesOf5Numbers.c

${OBJECTDIR}/07Sort3NumbersWithNestedIfs.o: 07Sort3NumbersWithNestedIfs.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07Sort3NumbersWithNestedIfs.o 07Sort3NumbersWithNestedIfs.c

${OBJECTDIR}/08DigitAsWord.o: 08DigitAsWord.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/08DigitAsWord.o 08DigitAsWord.c

${OBJECTDIR}/09PlayWithIntDoubleAndString.o: 09PlayWithIntDoubleAndString.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/09PlayWithIntDoubleAndString.o 09PlayWithIntDoubleAndString.c

${OBJECTDIR}/10BeerTime.o: 10BeerTime.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/10BeerTime.o 10BeerTime.c

${OBJECTDIR}/11NumberAsWords.o: 11NumberAsWords.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/11NumberAsWords.o 11NumberAsWords.c

${OBJECTDIR}/12ZeroSubset.o: 12ZeroSubset.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/12ZeroSubset.o 12ZeroSubset.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/05homeworkconditionalstatements

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
