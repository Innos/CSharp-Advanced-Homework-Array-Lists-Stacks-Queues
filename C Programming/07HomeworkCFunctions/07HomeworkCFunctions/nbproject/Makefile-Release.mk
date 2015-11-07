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
	${OBJECTDIR}/01BiggerNumber.o \
	${OBJECTDIR}/02LastDigitOfNumber.o \
	${OBJECTDIR}/03LastOccurenceOfCharacter.o \
	${OBJECTDIR}/04ReverseNumber.o \
	${OBJECTDIR}/05ArrayManipulation.o \
	${OBJECTDIR}/06FirstLargerThanNeighbours.o \
	${OBJECTDIR}/07RecursiveStringReverse.o \
	${OBJECTDIR}/ArrayManipulation.o


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
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/07homeworkcfunctions

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/07homeworkcfunctions: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/07homeworkcfunctions ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/01BiggerNumber.o: 01BiggerNumber.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/01BiggerNumber.o 01BiggerNumber.c

${OBJECTDIR}/02LastDigitOfNumber.o: 02LastDigitOfNumber.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/02LastDigitOfNumber.o 02LastDigitOfNumber.c

${OBJECTDIR}/03LastOccurenceOfCharacter.o: 03LastOccurenceOfCharacter.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03LastOccurenceOfCharacter.o 03LastOccurenceOfCharacter.c

${OBJECTDIR}/04ReverseNumber.o: 04ReverseNumber.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04ReverseNumber.o 04ReverseNumber.c

${OBJECTDIR}/05ArrayManipulation.o: 05ArrayManipulation.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05ArrayManipulation.o 05ArrayManipulation.c

${OBJECTDIR}/06FirstLargerThanNeighbours.o: 06FirstLargerThanNeighbours.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06FirstLargerThanNeighbours.o 06FirstLargerThanNeighbours.c

${OBJECTDIR}/07RecursiveStringReverse.o: 07RecursiveStringReverse.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07RecursiveStringReverse.o 07RecursiveStringReverse.c

${OBJECTDIR}/ArrayManipulation.o: ArrayManipulation.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/ArrayManipulation.o ArrayManipulation.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/07homeworkcfunctions

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
