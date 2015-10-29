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
	${OBJECTDIR}/01SaveAndPrintNumbersInRange.o \
	${OBJECTDIR}/02LinearSearch.o \
	${OBJECTDIR}/03SortArrayOfNumbers.o \
	${OBJECTDIR}/04CategorizeNumbersAndFindMinMaxAndAverage.o \
	${OBJECTDIR}/05LongestIncreasingSequence.o \
	${OBJECTDIR}/06JoinLists.o \
	${OBJECTDIR}/07ReverseArray.o \
	${OBJECTDIR}/08IterativeBinarySearch.o \
	${OBJECTDIR}/09RecursiveBinarySearch.o \
	${OBJECTDIR}/10NumbersBeneathMainDiagonal.o \
	${OBJECTDIR}/11ScalarMultiplicationOfAVector.o \
	${OBJECTDIR}/12DotProductOfVectors.o \
	${OBJECTDIR}/13CrossProductOfVectors.o \
	${OBJECTDIR}/14SumOfMatrices.o \
	${OBJECTDIR}/15MatrixMultiplication.o \
	${OBJECTDIR}/16TextGravity.o \
	${OBJECTDIR}/17TextBombardment.o \
	${OBJECTDIR}/BinarySearch.o \
	${OBJECTDIR}/QuickSort.o \
	${OBJECTDIR}/ReverseIntArray.o


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
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/08homeworkcarrays

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/08homeworkcarrays: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/08homeworkcarrays ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/01SaveAndPrintNumbersInRange.o: 01SaveAndPrintNumbersInRange.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/01SaveAndPrintNumbersInRange.o 01SaveAndPrintNumbersInRange.c

${OBJECTDIR}/02LinearSearch.o: 02LinearSearch.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/02LinearSearch.o 02LinearSearch.c

${OBJECTDIR}/03SortArrayOfNumbers.o: 03SortArrayOfNumbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03SortArrayOfNumbers.o 03SortArrayOfNumbers.c

${OBJECTDIR}/04CategorizeNumbersAndFindMinMaxAndAverage.o: 04CategorizeNumbersAndFindMinMaxAndAverage.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04CategorizeNumbersAndFindMinMaxAndAverage.o 04CategorizeNumbersAndFindMinMaxAndAverage.c

${OBJECTDIR}/05LongestIncreasingSequence.o: 05LongestIncreasingSequence.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05LongestIncreasingSequence.o 05LongestIncreasingSequence.c

${OBJECTDIR}/06JoinLists.o: 06JoinLists.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06JoinLists.o 06JoinLists.c

${OBJECTDIR}/07ReverseArray.o: 07ReverseArray.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07ReverseArray.o 07ReverseArray.c

${OBJECTDIR}/08IterativeBinarySearch.o: 08IterativeBinarySearch.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/08IterativeBinarySearch.o 08IterativeBinarySearch.c

${OBJECTDIR}/09RecursiveBinarySearch.o: 09RecursiveBinarySearch.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/09RecursiveBinarySearch.o 09RecursiveBinarySearch.c

${OBJECTDIR}/10NumbersBeneathMainDiagonal.o: 10NumbersBeneathMainDiagonal.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/10NumbersBeneathMainDiagonal.o 10NumbersBeneathMainDiagonal.c

${OBJECTDIR}/11ScalarMultiplicationOfAVector.o: 11ScalarMultiplicationOfAVector.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/11ScalarMultiplicationOfAVector.o 11ScalarMultiplicationOfAVector.c

${OBJECTDIR}/12DotProductOfVectors.o: 12DotProductOfVectors.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/12DotProductOfVectors.o 12DotProductOfVectors.c

${OBJECTDIR}/13CrossProductOfVectors.o: 13CrossProductOfVectors.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/13CrossProductOfVectors.o 13CrossProductOfVectors.c

${OBJECTDIR}/14SumOfMatrices.o: 14SumOfMatrices.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/14SumOfMatrices.o 14SumOfMatrices.c

${OBJECTDIR}/15MatrixMultiplication.o: 15MatrixMultiplication.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/15MatrixMultiplication.o 15MatrixMultiplication.c

${OBJECTDIR}/16TextGravity.o: 16TextGravity.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/16TextGravity.o 16TextGravity.c

${OBJECTDIR}/17TextBombardment.o: 17TextBombardment.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/17TextBombardment.o 17TextBombardment.c

${OBJECTDIR}/BinarySearch.o: BinarySearch.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/BinarySearch.o BinarySearch.c

${OBJECTDIR}/QuickSort.o: QuickSort.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/QuickSort.o QuickSort.c

${OBJECTDIR}/ReverseIntArray.o: ReverseIntArray.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/ReverseIntArray.o ReverseIntArray.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/08homeworkcarrays

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
