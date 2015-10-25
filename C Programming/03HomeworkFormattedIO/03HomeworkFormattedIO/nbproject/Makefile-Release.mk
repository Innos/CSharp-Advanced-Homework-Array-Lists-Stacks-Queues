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
	${OBJECTDIR}/01SumOf3Numbers.o \
	${OBJECTDIR}/02PrintCompanyInformation.o \
	${OBJECTDIR}/03CirclePerimeterAndArea.o \
	${OBJECTDIR}/04FormattingNumbers.o \
	${OBJECTDIR}/05SumOf5Numbers.o \
	${OBJECTDIR}/06NumbersFrom1ToN.o \
	${OBJECTDIR}/07SumOfNNumbers.o \
	${OBJECTDIR}/08FibonacciNumbers.o \
	${OBJECTDIR}/09NumbersInIntervalDividableBy5.o


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
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/03homeworkformattedio

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/03homeworkformattedio: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/03homeworkformattedio ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/01SumOf3Numbers.o: 01SumOf3Numbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/01SumOf3Numbers.o 01SumOf3Numbers.c

${OBJECTDIR}/02PrintCompanyInformation.o: 02PrintCompanyInformation.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/02PrintCompanyInformation.o 02PrintCompanyInformation.c

${OBJECTDIR}/03CirclePerimeterAndArea.o: 03CirclePerimeterAndArea.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03CirclePerimeterAndArea.o 03CirclePerimeterAndArea.c

${OBJECTDIR}/04FormattingNumbers.o: 04FormattingNumbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04FormattingNumbers.o 04FormattingNumbers.c

${OBJECTDIR}/05SumOf5Numbers.o: 05SumOf5Numbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05SumOf5Numbers.o 05SumOf5Numbers.c

${OBJECTDIR}/06NumbersFrom1ToN.o: 06NumbersFrom1ToN.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06NumbersFrom1ToN.o 06NumbersFrom1ToN.c

${OBJECTDIR}/07SumOfNNumbers.o: 07SumOfNNumbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07SumOfNNumbers.o 07SumOfNNumbers.c

${OBJECTDIR}/08FibonacciNumbers.o: 08FibonacciNumbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/08FibonacciNumbers.o 08FibonacciNumbers.c

${OBJECTDIR}/09NumbersInIntervalDividableBy5.o: 09NumbersInIntervalDividableBy5.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/09NumbersInIntervalDividableBy5.o 09NumbersInIntervalDividableBy5.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/03homeworkformattedio

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
