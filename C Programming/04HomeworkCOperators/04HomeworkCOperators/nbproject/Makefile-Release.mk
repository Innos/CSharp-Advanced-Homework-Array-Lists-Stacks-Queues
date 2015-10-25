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
	${OBJECTDIR}/01OddOrEvenIntegers.o \
	${OBJECTDIR}/02BigAndOdd.o \
	${OBJECTDIR}/03PureDivisor.o \
	${OBJECTDIR}/04GravitationOnTheMoon.o \
	${OBJECTDIR}/05DivideBy7And5.o \
	${OBJECTDIR}/06Rectangles.o \
	${OBJECTDIR}/07AverageSum.o \
	${OBJECTDIR}/08ThirdDigitIs7.o \
	${OBJECTDIR}/09FourDigitNumber.o \
	${OBJECTDIR}/10NthDigit.o \
	${OBJECTDIR}/11PointInsideACircle.o \
	${OBJECTDIR}/12PrimeNumberCheck.o \
	${OBJECTDIR}/13Trapezoids.o \
	${OBJECTDIR}/14PointInsideACircleAndOutsideARectangle.o


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
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/04homeworkcoperators

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/04homeworkcoperators: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/04homeworkcoperators ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/01OddOrEvenIntegers.o: 01OddOrEvenIntegers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/01OddOrEvenIntegers.o 01OddOrEvenIntegers.c

${OBJECTDIR}/02BigAndOdd.o: 02BigAndOdd.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/02BigAndOdd.o 02BigAndOdd.c

${OBJECTDIR}/03PureDivisor.o: 03PureDivisor.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03PureDivisor.o 03PureDivisor.c

${OBJECTDIR}/04GravitationOnTheMoon.o: 04GravitationOnTheMoon.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04GravitationOnTheMoon.o 04GravitationOnTheMoon.c

${OBJECTDIR}/05DivideBy7And5.o: 05DivideBy7And5.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05DivideBy7And5.o 05DivideBy7And5.c

${OBJECTDIR}/06Rectangles.o: 06Rectangles.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06Rectangles.o 06Rectangles.c

${OBJECTDIR}/07AverageSum.o: 07AverageSum.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07AverageSum.o 07AverageSum.c

${OBJECTDIR}/08ThirdDigitIs7.o: 08ThirdDigitIs7.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/08ThirdDigitIs7.o 08ThirdDigitIs7.c

${OBJECTDIR}/09FourDigitNumber.o: 09FourDigitNumber.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/09FourDigitNumber.o 09FourDigitNumber.c

${OBJECTDIR}/10NthDigit.o: 10NthDigit.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/10NthDigit.o 10NthDigit.c

${OBJECTDIR}/11PointInsideACircle.o: 11PointInsideACircle.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/11PointInsideACircle.o 11PointInsideACircle.c

${OBJECTDIR}/12PrimeNumberCheck.o: 12PrimeNumberCheck.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/12PrimeNumberCheck.o 12PrimeNumberCheck.c

${OBJECTDIR}/13Trapezoids.o: 13Trapezoids.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/13Trapezoids.o 13Trapezoids.c

${OBJECTDIR}/14PointInsideACircleAndOutsideARectangle.o: 14PointInsideACircleAndOutsideARectangle.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/14PointInsideACircleAndOutsideARectangle.o 14PointInsideACircleAndOutsideARectangle.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/04homeworkcoperators

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
