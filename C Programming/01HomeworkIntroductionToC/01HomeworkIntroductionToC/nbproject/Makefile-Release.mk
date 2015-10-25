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
	${OBJECTDIR}/03HelloC.o \
	${OBJECTDIR}/04PrintYourName.o \
	${OBJECTDIR}/05PrintNumbers.o \
	${OBJECTDIR}/06PrintFirstAndLastName.o \
	${OBJECTDIR}/07SquareRoot.o \
	${OBJECTDIR}/08PrintASequence.o \
	${OBJECTDIR}/12CurrentDateAndTime.o \
	${OBJECTDIR}/13AgeAfter10Years.o


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
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/homeworkintroductiontoc

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/homeworkintroductiontoc: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/homeworkintroductiontoc ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/03HelloC.o: 03HelloC.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03HelloC.o 03HelloC.c

${OBJECTDIR}/04PrintYourName.o: 04PrintYourName.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04PrintYourName.o 04PrintYourName.c

${OBJECTDIR}/05PrintNumbers.o: 05PrintNumbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05PrintNumbers.o 05PrintNumbers.c

${OBJECTDIR}/06PrintFirstAndLastName.o: 06PrintFirstAndLastName.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06PrintFirstAndLastName.o 06PrintFirstAndLastName.c

${OBJECTDIR}/07SquareRoot.o: 07SquareRoot.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07SquareRoot.o 07SquareRoot.c

${OBJECTDIR}/08PrintASequence.o: 08PrintASequence.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/08PrintASequence.o 08PrintASequence.c

${OBJECTDIR}/12CurrentDateAndTime.o: 12CurrentDateAndTime.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/12CurrentDateAndTime.o 12CurrentDateAndTime.c

${OBJECTDIR}/13AgeAfter10Years.o: 13AgeAfter10Years.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/13AgeAfter10Years.o 13AgeAfter10Years.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/homeworkintroductiontoc

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
