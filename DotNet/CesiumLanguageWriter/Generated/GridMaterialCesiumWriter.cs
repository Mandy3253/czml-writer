// <auto-generated>
// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>GridMaterial</c> to a <see cref="CesiumOutputStream" />.  A <c>GridMaterial</c> is a material that fills the surface with a two dimensional grid.
    /// </summary>
    public class GridMaterialCesiumWriter : CesiumPropertyWriter<GridMaterialCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>color</c> property.
        /// </summary>
        public const string ColorPropertyName = "color";

        /// <summary>
        /// The name of the <c>cellAlpha</c> property.
        /// </summary>
        public const string CellAlphaPropertyName = "cellAlpha";

        /// <summary>
        /// The name of the <c>lineCount</c> property.
        /// </summary>
        public const string LineCountPropertyName = "lineCount";

        /// <summary>
        /// The name of the <c>lineThickness</c> property.
        /// </summary>
        public const string LineThicknessPropertyName = "lineThickness";

        /// <summary>
        /// The name of the <c>lineOffset</c> property.
        /// </summary>
        public const string LineOffsetPropertyName = "lineOffset";

        private readonly Lazy<ColorCesiumWriter> m_color = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(ColorPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_cellAlpha = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(CellAlphaPropertyName), false);
        private readonly Lazy<LineCountCesiumWriter> m_lineCount = new Lazy<LineCountCesiumWriter>(() => new LineCountCesiumWriter(LineCountPropertyName), false);
        private readonly Lazy<LineThicknessCesiumWriter> m_lineThickness = new Lazy<LineThicknessCesiumWriter>(() => new LineThicknessCesiumWriter(LineThicknessPropertyName), false);
        private readonly Lazy<LineOffsetCesiumWriter> m_lineOffset = new Lazy<LineOffsetCesiumWriter>(() => new LineOffsetCesiumWriter(LineOffsetPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public GridMaterialCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected GridMaterialCesiumWriter(GridMaterialCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override GridMaterialCesiumWriter Clone()
        {
            return new GridMaterialCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>color</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>color</c> property defines the color of the surface.
        /// </summary>
        public ColorCesiumWriter ColorWriter
        {
            get { return m_color.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>color</c> property.  The <c>color</c> property defines the color of the surface.
        /// </summary>
        public ColorCesiumWriter OpenColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorProperty(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorPropertyReference(Reference value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteColorPropertyReference(string value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>cellAlpha</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>cellAlpha</c> property defines the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        public DoubleCesiumWriter CellAlphaWriter
        {
            get { return m_cellAlpha.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>cellAlpha</c> property.  The <c>cellAlpha</c> property defines the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        public DoubleCesiumWriter OpenCellAlphaProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(CellAlphaWriter);
        }

        /// <summary>
        /// Writes a value for the <c>cellAlpha</c> property as a <c>number</c> value.  The <c>cellAlpha</c> property specifies the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteCellAlphaProperty(double value)
        {
            using (var writer = OpenCellAlphaProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>cellAlpha</c> property as a <c>number</c> value.  The <c>cellAlpha</c> property specifies the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteCellAlphaProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenCellAlphaProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>cellAlpha</c> property as a <c>number</c> value.  The <c>cellAlpha</c> property specifies the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteCellAlphaProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenCellAlphaProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>cellAlpha</c> property as a <c>reference</c> value.  The <c>cellAlpha</c> property specifies the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteCellAlphaPropertyReference(Reference value)
        {
            using (var writer = OpenCellAlphaProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>cellAlpha</c> property as a <c>reference</c> value.  The <c>cellAlpha</c> property specifies the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteCellAlphaPropertyReference(string value)
        {
            using (var writer = OpenCellAlphaProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>cellAlpha</c> property as a <c>reference</c> value.  The <c>cellAlpha</c> property specifies the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteCellAlphaPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenCellAlphaProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>cellAlpha</c> property as a <c>reference</c> value.  The <c>cellAlpha</c> property specifies the alpha value for the space between grid lines.  This will be combined with the color alpha.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteCellAlphaPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenCellAlphaProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>lineCount</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>lineCount</c> property defines the number of grid lines along each axis.
        /// </summary>
        public LineCountCesiumWriter LineCountWriter
        {
            get { return m_lineCount.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>lineCount</c> property.  The <c>lineCount</c> property defines the number of grid lines along each axis.
        /// </summary>
        public LineCountCesiumWriter OpenLineCountProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(LineCountWriter);
        }

        /// <summary>
        /// Writes a value for the <c>lineCount</c> property as a <c>cartesian2</c> value.  The <c>lineCount</c> property specifies the number of grid lines along each axis.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteLineCountProperty(Rectangular value)
        {
            using (var writer = OpenLineCountProperty())
            {
                writer.WriteCartesian2(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineCount</c> property as a <c>cartesian2</c> value.  The <c>lineCount</c> property specifies the number of grid lines along each axis.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public void WriteLineCountProperty(double x, double y)
        {
            using (var writer = OpenLineCountProperty())
            {
                writer.WriteCartesian2(x, y);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineCount</c> property as a <c>cartesian2</c> value.  The <c>lineCount</c> property specifies the number of grid lines along each axis.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteLineCountProperty(IList<JulianDate> dates, IList<Rectangular> values)
        {
            using (var writer = OpenLineCountProperty())
            {
                writer.WriteCartesian2(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineCount</c> property as a <c>cartesian2</c> value.  The <c>lineCount</c> property specifies the number of grid lines along each axis.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteLineCountProperty(IList<JulianDate> dates, IList<Rectangular> values, int startIndex, int length)
        {
            using (var writer = OpenLineCountProperty())
            {
                writer.WriteCartesian2(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineCount</c> property as a <c>reference</c> value.  The <c>lineCount</c> property specifies the number of grid lines along each axis.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteLineCountPropertyReference(Reference value)
        {
            using (var writer = OpenLineCountProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineCount</c> property as a <c>reference</c> value.  The <c>lineCount</c> property specifies the number of grid lines along each axis.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteLineCountPropertyReference(string value)
        {
            using (var writer = OpenLineCountProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineCount</c> property as a <c>reference</c> value.  The <c>lineCount</c> property specifies the number of grid lines along each axis.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteLineCountPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenLineCountProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineCount</c> property as a <c>reference</c> value.  The <c>lineCount</c> property specifies the number of grid lines along each axis.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteLineCountPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenLineCountProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>lineThickness</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>lineThickness</c> property defines the thickness of grid lines along each axis, in pixels.
        /// </summary>
        public LineThicknessCesiumWriter LineThicknessWriter
        {
            get { return m_lineThickness.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>lineThickness</c> property.  The <c>lineThickness</c> property defines the thickness of grid lines along each axis, in pixels.
        /// </summary>
        public LineThicknessCesiumWriter OpenLineThicknessProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(LineThicknessWriter);
        }

        /// <summary>
        /// Writes a value for the <c>lineThickness</c> property as a <c>cartesian2</c> value.  The <c>lineThickness</c> property specifies the thickness of grid lines along each axis, in pixels.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteLineThicknessProperty(Rectangular value)
        {
            using (var writer = OpenLineThicknessProperty())
            {
                writer.WriteCartesian2(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineThickness</c> property as a <c>cartesian2</c> value.  The <c>lineThickness</c> property specifies the thickness of grid lines along each axis, in pixels.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public void WriteLineThicknessProperty(double x, double y)
        {
            using (var writer = OpenLineThicknessProperty())
            {
                writer.WriteCartesian2(x, y);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineThickness</c> property as a <c>cartesian2</c> value.  The <c>lineThickness</c> property specifies the thickness of grid lines along each axis, in pixels.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteLineThicknessProperty(IList<JulianDate> dates, IList<Rectangular> values)
        {
            using (var writer = OpenLineThicknessProperty())
            {
                writer.WriteCartesian2(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineThickness</c> property as a <c>cartesian2</c> value.  The <c>lineThickness</c> property specifies the thickness of grid lines along each axis, in pixels.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteLineThicknessProperty(IList<JulianDate> dates, IList<Rectangular> values, int startIndex, int length)
        {
            using (var writer = OpenLineThicknessProperty())
            {
                writer.WriteCartesian2(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineThickness</c> property as a <c>reference</c> value.  The <c>lineThickness</c> property specifies the thickness of grid lines along each axis, in pixels.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteLineThicknessPropertyReference(Reference value)
        {
            using (var writer = OpenLineThicknessProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineThickness</c> property as a <c>reference</c> value.  The <c>lineThickness</c> property specifies the thickness of grid lines along each axis, in pixels.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteLineThicknessPropertyReference(string value)
        {
            using (var writer = OpenLineThicknessProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineThickness</c> property as a <c>reference</c> value.  The <c>lineThickness</c> property specifies the thickness of grid lines along each axis, in pixels.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteLineThicknessPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenLineThicknessProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineThickness</c> property as a <c>reference</c> value.  The <c>lineThickness</c> property specifies the thickness of grid lines along each axis, in pixels.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteLineThicknessPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenLineThicknessProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>lineOffset</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>lineOffset</c> property defines the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        public LineOffsetCesiumWriter LineOffsetWriter
        {
            get { return m_lineOffset.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>lineOffset</c> property.  The <c>lineOffset</c> property defines the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        public LineOffsetCesiumWriter OpenLineOffsetProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(LineOffsetWriter);
        }

        /// <summary>
        /// Writes a value for the <c>lineOffset</c> property as a <c>cartesian2</c> value.  The <c>lineOffset</c> property specifies the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteLineOffsetProperty(Rectangular value)
        {
            using (var writer = OpenLineOffsetProperty())
            {
                writer.WriteCartesian2(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineOffset</c> property as a <c>cartesian2</c> value.  The <c>lineOffset</c> property specifies the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public void WriteLineOffsetProperty(double x, double y)
        {
            using (var writer = OpenLineOffsetProperty())
            {
                writer.WriteCartesian2(x, y);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineOffset</c> property as a <c>cartesian2</c> value.  The <c>lineOffset</c> property specifies the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteLineOffsetProperty(IList<JulianDate> dates, IList<Rectangular> values)
        {
            using (var writer = OpenLineOffsetProperty())
            {
                writer.WriteCartesian2(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineOffset</c> property as a <c>cartesian2</c> value.  The <c>lineOffset</c> property specifies the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteLineOffsetProperty(IList<JulianDate> dates, IList<Rectangular> values, int startIndex, int length)
        {
            using (var writer = OpenLineOffsetProperty())
            {
                writer.WriteCartesian2(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineOffset</c> property as a <c>reference</c> value.  The <c>lineOffset</c> property specifies the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteLineOffsetPropertyReference(Reference value)
        {
            using (var writer = OpenLineOffsetProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineOffset</c> property as a <c>reference</c> value.  The <c>lineOffset</c> property specifies the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteLineOffsetPropertyReference(string value)
        {
            using (var writer = OpenLineOffsetProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineOffset</c> property as a <c>reference</c> value.  The <c>lineOffset</c> property specifies the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteLineOffsetPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenLineOffsetProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>lineOffset</c> property as a <c>reference</c> value.  The <c>lineOffset</c> property specifies the offset of grid lines along each axis, as a percentage from 0 to 1.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteLineOffsetPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenLineOffsetProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
